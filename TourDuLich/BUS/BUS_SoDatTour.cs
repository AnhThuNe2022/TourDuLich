using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourDuLich.DAO;
using System.Windows.Forms;
using System.Transactions;

namespace TourDuLich.BUS
{
    class BUS_SoDatTour
    {
        DAO_SoDatTour dao_dt;
        DAO_KhachHang dao_kh;
        DAO_ChiTietDonHang dao_ct;
        DAO_Tour dao_t;
        DAO_HuyTour dao_h;
        public BUS_SoDatTour()
        {
            dao_dt = new DAO_SoDatTour();
            dao_kh = new DAO_KhachHang();
            dao_ct = new DAO_ChiTietDonHang();
            dao_t = new DAO_Tour();
            dao_h = new DAO_HuyTour();
        }    

        public int kiemTraKHDatTour(int maKH, String maTour)
        {
            if (dao_kh.kiemTraKH(maKH))
            {
                if (!dao_dt.KiemTraKHDatTour(maKH,maTour))
                {

                    return 1;
                }
                else
                    return -1;
            }
            else
                return 0;       
        }



        public int Dat_Tour(SoDatTour st, List<ChiTietDatVe> List_v)
        {
            if (dao_t.KtSoLuongVe(st.MaTour, List_v.Count))
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    try
                    {
                        dao_dt.DatTour(st);
                        foreach (ChiTietDatVe v in List_v)
                        {
                            dao_ct.themChiTiet(v);
                        }
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
            else
                return -3;
        }



        public bool KTKhachHang(int maKH)
        {
            if (dao_kh.kiemTraKH(maKH))
                return true;
            return false;
        }

        public String GetLast()
        {
            SoDatTour st = dao_dt.GetLast();
            if ( st!= null)
            {
                return st.MaDon;
            }
            else
                return "0";
        }

        public void List_SoDatTour(DataGridView gv)
        {
            try
            {
                gv.DataSource =  dao_dt.List_SoDatTour();
         
            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
              
            }

        }    

        public void cbTour(ComboBox c)
        {

            try
            {
                c.DataSource = dao_t.List_TourSDT();
                c.DisplayMember = "MaTour";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }

        public int SuaDH(SoDatTour t)
        {
            if (dao_dt.CheckDonHang(t.MaDon))
            {
                try
                {
                    dao_dt.SuaDonHang(t);
                    return 1;

                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            } 
            else
            {
                return 0;
            }    
                
        }

        public int XoaDonHang(String maDH)
        {
            if (dao_dt.CheckDonHang(maDH))
            {
                try
                {
                    if (dao_ct.List_ChiTietTheoMaDH(maDH) == null)
                    {
                        dao_dt.XoaDonHang(maDH);
                        return 1;
                    }
                    else
                        return -1;
                }
                catch(SqlException e)
                {
                    MessageBox.Show(e.Message);
                    return -2;
                }
                
            }
            else
                return 0;
        }

        public int XoaDonHangCoChiTiet(String maDH)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    List<String> DSMaCT = dao_ct.DSMaChiTiet(maDH);
                    List<String> DSMaHuyTour = new List<string>();
                    foreach (String t in DSMaCT)
                    {
                        if (dao_h.checkChiTietTrongHuyTour(t))
                             DSMaHuyTour.Add(t);
                    }
                    if (DSMaHuyTour != null)
                    {
                        foreach (String t in DSMaHuyTour)
                        {
                            dao_h.XoaHuyTourTheoChiTiet(t);
                        }

                    }
                 
                    dao_ct.XoaChiTietTheoDonHang(maDH);
         
                    dao_dt.XoaDonHang(maDH);
                 
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
