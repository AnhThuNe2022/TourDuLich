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
    class BUS_KhachHang
    {
        DAO_KhachHang dao_kh;
        DAO_SoDatTour dao_s;
        DAO_ChiTietDonHang dao_ct;
        DAO_HuyTour dao_h;
        public BUS_KhachHang()
        {
            dao_kh = new DAO_KhachHang();
            dao_s = new DAO_SoDatTour();
            dao_ct = new DAO_ChiTietDonHang();
            dao_h = new DAO_HuyTour();
        }
        public int GetKH(decimal sđt, String mk, ref KH KhachHang)
        {
            KhachHang = dao_kh.FindKH(sđt, mk);
            if (KhachHang != null)
            {
                return 1;
            }
            else
                return 0;

        }
        public void List_KH(DataGridView gv)
        {
            try
            {
                gv.DataSource = dao_kh.List_KH();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //if (!dao_nv.checkSDT(nv.SĐT.ToString()))
        //    {

        //        try
        //        {

        //            dao_nv.themNV(nv);
        //            return 1;
        //        }
        //        catch (SqlException e)
        //        {
        //            MessageBox.Show(e.Message);
        //            return 0;
        //        }
        //    }
        //    else
        //        return -1;

        public int ThemKH(KH KhachHang)
        {
            if (!dao_kh.CheckSDT(KhachHang.SĐT.ToString()))
            {
                try
                {
                    dao_kh.ThemKH(KhachHang);
                    return 1;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                    return -2;
                }
            }
            else
                return 0;
        }

        public int SuaKH(KH k)
        {
            if (dao_kh.kiemTraKH(k.MaKH))
            {
                if (!dao_kh.CheckSDT2(k.MaKH,k.SĐT.ToString()))
                {
                    try
                    {
                        dao_kh.SuaKH(k);
                        return 1;
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                        return -2;
                    }

                }
                else
                    return -1;
            }
            else
                return 0;
        }



        public int XoaKH(int maKH)
        {
            if (dao_kh.kiemTraKH(maKH))
            {
                try
                {

                    if (dao_s.KiemTraKH_SoDat(maKH))
                    {
                        return -1;
                    }
                    else
                        dao_kh.XoaKH(maKH);
                    return 1;
                }
                catch (SqlException e)
                {

                    MessageBox.Show(e.Message);
                    return -2;
                }

            }
            else
                return 0;
        }



        public int XoaKHTonTaiTrongSoDatTour(int maKH)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {

                    List<String> DSMaDH = dao_s.DSMaDonHangTheoKH(maKH);
                    List<String> DSMaChiTiet = new List<string>();
                    List<String> DSMahHuyTour = new List<string>();

                    foreach (String t in DSMaDH)
                    {
                        DSMaChiTiet.AddRange(dao_ct.DSMaChiTiet(t));
                    }

                    if (DSMaChiTiet != null)
                    {
                        foreach (String t in DSMaChiTiet)
                        {
                            if (dao_h.checkChiTietTrongHuyTour(t))
                                DSMahHuyTour.Add(t);
                        }
                        if (DSMahHuyTour != null)
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
                            

                        }
                        else
                        {
                            foreach (String t in DSMaDH)
                            {
                                dao_ct.XoaChiTietTheoDonHang(t);
                            }
                          

                        }
                    }
                    dao_s.XoaSoDatTourTheoKH(maKH);
                    dao_kh.XoaKH(maKH);
                    trans.Complete();
                    return 1;
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                    return 0;
                }

            }

        }
    }
}
