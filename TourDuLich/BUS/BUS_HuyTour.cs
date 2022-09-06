using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourDuLich.DAO;
using System.Windows.Forms;
namespace TourDuLich.BUS
{
    class BUS_HuyTour
    {
        DAO_HuyTour dao_ht;
        DAO_ChiTietDonHang dao_ct;
        DAO_SoDatTour dao_s;

        public BUS_HuyTour()
        {
            dao_ht = new DAO_HuyTour();
            dao_ct = new DAO_ChiTietDonHang();
            dao_s = new DAO_SoDatTour();
            
        }

        public int Huy_Tour(HuyTour ht)
        {
            if (dao_ct.KtMaVe(ht.MaVe))
            {
                if (dao_ht.KTMaVeDuyNhat(ht.MaVe))
                {

                    try
                    {
                        dao_ht.themHuyTour(ht);
                        return 1;
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                        return -1;
                    }
                }
                else
                    return -2;
            }
            else
                return 0;
        }

        public String GetLast()
        {
            HuyTour st = dao_ht.GetLast();
            if (st != null)
            {
                return st.MaHuyTour;
            }
            else
                return "0";
        }


        public void List_Huy(DataGridView gv)
        {
            try
            {
                gv.DataSource = dao_ht.List_HuyTour();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void List_MaVe(ComboBox c)
        {
            try
            {

                c.DataSource = dao_ct.List_ChiTiet();
                c.DisplayMember = "MaDonHang";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }


        public int Xoa_HuyTour(String maHuy)
        {
            if (dao_ht.KTMaHT(maHuy))
            {

                try
                {
                    dao_ht.XoaHuyTour(maHuy);
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
        //public void KhoiPhucVe(String maVe)
        //{
        //    dao_ht.KhoiPhucVe(maVe);
        //}

        public int HoanChoHuyVe(String maVe)
        {
            try
            {
                String maDH = dao_ct.GetMaDh(maVe);
                dao_s.HoanChoHuyVe(maDH);
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }

        }
    }
}
