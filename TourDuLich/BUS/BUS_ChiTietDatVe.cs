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
    class BUS_ChiTietDatVe
    {

        DAO_ChiTietDonHang dao_ct;
        DAO_Tour dao_tour;
        DAO_HuyTour dao_ht;
        DAO_SoDatTour dao_sdt;
        public BUS_ChiTietDatVe()
        {
            dao_ct = new DAO_ChiTietDonHang();
            dao_tour = new DAO_Tour();
            dao_ht = new DAO_HuyTour();
            dao_sdt = new DAO_SoDatTour();

        }

        public String GetLastChiTiet()
        {
            List<ChiTietDatVe> ct = dao_ct.GetLast_List(dao_sdt.GetLast().MaTour);
            if (ct != null)
            {
                int max = int.Parse(ct[0].MaVe.Substring(2));
                for (int i = 1; i < ct.Count; i++)
                {
                    if (int.Parse(ct[i].MaVe.Substring(2)) > max)
                    {
                        max = int.Parse(ct[i].MaVe.Substring(2));
                    }

                }
                return max.ToString();
            }
            else
                return "0";
        }

        public int List_CTDV(int maKH, ref List<ChiTietDatVe> ct)
        {
            if (dao_ct.KtChiTiet(maKH) == true)
            {
                try
                {
                    ct = dao_ct.List_CTDV(maKH);
                    if (ct != null)
                    {
                        foreach (ChiTietDatVe v in ct.ToList())
                        {
                            if (dao_ht.KiemTraMaVe(v.MaVe))
                                ct.Remove(v);

                        }
                        return 1;
                    }
                    return -2;

                } catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            }
            else
                return 0;
        }

        public List<Tour> List_TourCT(List<ChiTietDatVe> ct)
        {
            try
            {
                List<Tour> t = new List<Tour>();
                for (int i = 0; i < ct.Count; i++)
                {
                    t.Add(dao_tour.getTour(ct[i].SoDatTour.MaTour));

                }
                if (t.Count != ct.Count)
                    return null;
                else
                    return t;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public List<ChiTietDatVe> List_CTDV(String maDH)
        {
            try
            {
                return dao_ct.List_ChiTietTheoMaDH(maDH);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }


        }
        public int ThemListChiTiet(String maTour, List<ChiTietDatVe> List_v)
        {

            if (dao_tour.KtSoLuongVe(maTour, List_v.Count))
            {
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        try
                        {

                            foreach (ChiTietDatVe v in List_v)
                            {
                                if (dao_ct.KTMaChiTiet(v.MaVe))
                                    dao_ct.themChiTiet(v);
                                else
                                {
                                    return -1;
                                }
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
            }
            else
                return -3;

        }
            public bool ChiTietTonTai(String maCT)
            {
                if (!dao_ct.KTMaChiTiet(maCT))
                {
                    return true;
                }
                return false;
            }


            public bool KTChiTietDaHuyTour(List<String> maCT)
            {
                for (int i = 0; i < maCT.Count; i++)
                {
                    if (dao_ht.checkChiTietTrongHuyTour(maCT[i]))
                    {
                        return true;
                    }

                }
                return false;
            }


            public void XoaChiTiet(List<String> mact)
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    try
                    {
                        foreach (String v in mact)
                        {
                            dao_ct.XoaListChiTiet(v);
                        }
                        trans.Complete();

                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }

            public void XoaChiTietHuyTour(List<String> mact)
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    try
                    {
                        for (int i = 0; i < mact.Count; i++)
                        {
                            if (dao_ht.checkChiTietTrongHuyTour(mact[i]))
                            {
                                dao_ht.XoaHuyTourTheoChiTiet(mact[i]);
                            }
                        }
                        foreach (String v in mact)
                        {
                            dao_ct.XoaListChiTiet(v);
                        }
                        trans.Complete();

                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }





        
    }
}