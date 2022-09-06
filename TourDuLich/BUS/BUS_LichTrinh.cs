using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourDuLich.DAO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace TourDuLich.BUS
{
    class BUS_LichTrinh
    {
        DAO_LichTrinh dao_lt;
        DAO_Tour dao_tour;
        DAO_HuyTour dao_h;
        DAO_SoDatTour dao_s;
        DAO_ChiTietDonHang dao_ct;

        public BUS_LichTrinh()
        {
            dao_lt = new DAO_LichTrinh();
            dao_ct = new DAO_ChiTietDonHang();
            dao_h = new DAO_HuyTour();
            dao_s = new DAO_SoDatTour();
            dao_tour = new DAO_Tour();
        }
        public int List_LichTrinh(DataGridView g)
        {
            try
            {
                g.DataSource = dao_lt.List_LichTrinh();
                return 1;

            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public int ThemLichTrinh(LichTrinhTour l)
        {
            try
            {
                dao_lt.ThemLichTrinh(l);
                return 1;

            }catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public String GetLast()
        {

            LichTrinhTour s = dao_lt.GetLast();
            if(s!= null)
            {
                int ma = int.Parse(s.MaLichTrinh.Substring(2));
                ma++;
                return "LT" + ma;
            } 
            else
                return "LT1";
        }

        public int SuaLichTrinh(LichTrinhTour l)
        {
            if (dao_lt.CheckLichTrinh(l.MaLichTrinh))
            {
                try
                {
                    dao_lt.SuaLichTrinh(l);
                    return 1;
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                    return -1;
                }

            }
            else
            {
                return 0;
            }    

        }
        public int XoaLichTrinh(String ma)
        {
            if (dao_lt.CheckLichTrinh(ma))
            {
                if (!dao_tour.CheckLichTrinhTour(ma))
                {
                    try
                    {
                        dao_lt.XoaLichTrinh(ma);
                        return 1;
                    }
                    catch (SqlException s)
                    {
                        MessageBox.Show(s.Message);
                        return -2;
                    }
                }
                else
                    return -1;


            }
            else
                return 0;
        }

        public int XoaLichTrinhCoTrongTour( String maLichTrinh)
        {
            using (TransactionScope trans = new TransactionScope())
            {

                try
                {

                    List<String> DSMaTour = dao_tour.DSMaTour(maLichTrinh);
                    List<String> DSMaDH = new List<string>();
                    List<String> DSMaChiTiet = new List<string>();
                    List<String> DSMahHuyTour = new List<string>();

                        foreach (String t in DSMaTour)
                        {
                            DSMaDH.AddRange(dao_s.DSMaDonHang(t));
                        }

                        if(DSMaDH != null)
                        {
                            
                            foreach (String t in DSMaDH)
                            {
                                DSMaChiTiet.AddRange(dao_ct.DSMaChiTiet(t));
                            }

                            if (DSMaChiTiet != null)
                            {
                                    foreach (String t in DSMaChiTiet)
                                    {
                                        if(dao_h.checkChiTietTrongHuyTour(t))
                                            DSMahHuyTour.Add(t);
                                    }
                                    if(DSMahHuyTour != null)
                                    {

                                        //Xóa ở cả 3 
                                        foreach (String t in DSMahHuyTour)
                                        {
                                            dao_h.XoaHuyTourTheoChiTiet(t);
                                        }
                                        foreach (String t in DSMaDH)
                                        {
                                            dao_ct.XoaChiTietTheoDonHang(t);
                                        }
                                        foreach (String t in DSMaTour)
                                        {
                                            dao_s.XoaSoDatTourTheoTour(t);
                                        }


                                    }
                                    else
                                    {
                                        foreach (String t in DSMaDH)
                                        {
                                            dao_ct.XoaChiTietTheoDonHang(t);
                                        }
                                        foreach (String t in DSMaTour)
                                        {
                                            dao_s.XoaSoDatTourTheoTour(t);
                                        }

                                     }


                             }
                            else
                            {
                                foreach (String t in DSMaTour)
                                {
                                    dao_s.XoaSoDatTourTheoTour(t);
                                }
                            }    



                        }
                    dao_tour.XoaTourTheoLichTrinh(maLichTrinh);
                    dao_lt.XoaLichTrinh(maLichTrinh);
                    trans.Complete();
                    return 1;
                }
                catch (SqlException e)
                {

                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
           
           

        }


    }
}
