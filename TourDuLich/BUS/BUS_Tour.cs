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
    class BUS_Tour
    {
        DAO_Tour dao_Tour;
        DAO_NhanVien dao_nv;
        DAO_LichTrinh dao_lt;
        DAO_SoDatTour dao_s;
        DAO_ChiTietDonHang dao_ct;
        DAO_HuyTour dao_h;

        public BUS_Tour()
        {
            dao_Tour = new DAO_Tour();
            dao_nv = new DAO_NhanVien();
            dao_lt = new DAO_LichTrinh();
            dao_s = new DAO_SoDatTour();
            dao_ct = new DAO_ChiTietDonHang();
            dao_h = new DAO_HuyTour();

        }

        public void List_DiemKhoiHanh(ComboBox c)
        {
            try
            {
                c.DataSource = dao_Tour.List_KhoiHanh();

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }
        public void List_DiemDen(ComboBox c)
        {
            try
            {

                c.DataSource = dao_Tour.List_DiemDen();
                c.DisplayMember = "Tinh";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }

        public List<Tour> List_Tour()
        {
            try
            {
                List<Tour> a = dao_Tour.List_Tour();
                return a;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public List<Tour> List_Tour2()
        {
            try
            {
                List<Tour> a = dao_Tour.List_TourQL();
                return a;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public List<Tour> change(String noiKH, String diemDen, int gia, int tinhTrang, DateTime ngayKH)
        {
            try
            {
                List<Tour> t = dao_Tour.change(noiKH, diemDen, gia, tinhTrang, ngayKH);
                return t;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }



        public int showTour(String maTour, ref Tour tour)
        {
            try
            {

                Tour t = dao_Tour.getTour(maTour);
                if (t != null)
                {
                    tour = t;
                    return 1;
                }
                else
                    return 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }


        public void List_NguoiDieuHanh(ComboBox c)
        {
            try
            {

                c.DataSource = dao_nv.GetNVDieuHanh_Tour();
                c.DisplayMember = "MaNhanVien";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }


        public void List_LichTrinhTour(ComboBox c)
        {
            try
            {

                c.DataSource = dao_lt.List_LichTrinh();
                c.DisplayMember = "MaLichTrinh";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }

        public int ThemTour(Tour t)
        {
            try
            {
                dao_Tour.ThemTour(t);
                return 1;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public String GetMaTour()
        {

            List<Tour> List = dao_Tour.List_Tour();
            int max = int.Parse(List[0].MaTour.Substring(1));
            for (int i = 1; i < List.Count; i++)
            {
                int s = int.Parse(List[i].MaTour.Substring(1));
                if (s > max)
                    max = s;

            }
            max++;
            return "T" + max;
        }

        public int SuaTour(Tour t)
        {
            if (dao_Tour.CheckTour(t.MaTour))
            {
                try
                {
                    dao_Tour.SuaTour(t);
                    return 1;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }

            }
            else
                return 0;
        }

        public int XoaTour(String maTour)
        {
            if (dao_Tour.CheckTour(maTour))
            {
                try
                {
                    if (!dao_s.KiemTraTour_SoDat(maTour))
                    {
                        dao_Tour.XoaTour(maTour); ;
                        return 1;
                    }
                    else
                        return -1;
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

        public int XoaTourCoDonHang(String maTour)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {

                    List<String> DSMaDH = dao_s.DSMaDonHang(maTour);
                    List<String> DSMaChiTiet = new List<string>();
                    List<String> DSMaHuyTour = new List<string>();

                    foreach (String t in DSMaDH)
                    {
                        DSMaChiTiet.AddRange(dao_ct.DSMaChiTiet(t));
                    }
                    if (DSMaChiTiet != null)
                    {

                        foreach (String t in DSMaChiTiet)
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

                    //dao_ct.XoaChiTietTheoDonHang(maDH);

                    dao_s.XoaSoDatTourTheoTour(maTour);
                    dao_Tour.XoaTour(maTour);
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
