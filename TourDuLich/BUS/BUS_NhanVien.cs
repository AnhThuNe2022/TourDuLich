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
    class BUS_NhanVien
    {
        DAO_NhanVien dao_nv;
        DAO_Tour dao_t;
        DAO_SoDatTour dao_s;
        DAO_HuyTour dao_h;  
        DAO_ChiTietDonHang dao_ct;

        public BUS_NhanVien()
        {
            dao_nv = new DAO_NhanVien();
            dao_t = new DAO_Tour();
            dao_s = new DAO_SoDatTour();
            dao_h = new DAO_HuyTour();
            dao_ct = new DAO_ChiTietDonHang();
        }
        public int GetNV(decimal sdt, String mk, ref NhanVien nv)
        {
            nv = dao_nv.FindNV(sdt, mk);
            if (nv != null)
            {
                return 1;
            }
            else
                return 0;

        }
        public void show(DataGridView k)
        {
            try
            {
                k.DataSource = dao_nv.List_NhanVien();

            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int themNV(NhanVien nv)
        {
            if (!dao_nv.checkSDT(nv.SĐT.ToString()))
            {

                try
                {

                    dao_nv.themNV(nv);
                    return 1;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
            else
                return -1;
        }

        public String GetLastMaNV()
        {
            List<String> s = dao_nv.GetMaNV();

            if (s!=null)
            {
                int max = int.Parse(s[0].Substring(2));
                for (int i = 1; i < s.Count; i++)
                {
                    int k = int.Parse(s[i].Substring(2));
                    if (k > max)
                        max = k;

                }
                max++;
                return "NV" + max; 
            }
            else
                return "NV1";
        }

        public int SuaNV(NhanVien nv)
        {
            if(dao_nv.CheckNV(nv.MaNhanVien))
            {
                if (!dao_nv.checkSDT2(nv.MaNhanVien,nv.SĐT.ToString()))
                {

                    try
                    {
                        dao_nv.SuaNV(nv);
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
            {
                return 0;
            }
        }

        public int XoaNV(String maNV, String ChucVu)
        {
            if (dao_nv.CheckNV(maNV))
            {
                try
                {

                    if (ChucVu == "Điều Hành Du Lịch" || ChucVu == "Hướng Dẫn Viên Du Lịch ")
                    {
                        if (dao_t.CheckNVTrongTour(maNV))
                        {
                            return -1;
                        }

                    }
                    dao_nv.XoaNV(maNV);
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
        public int XoaNhanVienTonTaiTrongTour(String maNV)
        {
            try
            {
                List<String> s = dao_t.DSMaTour_NV(maNV);
                for(int i = 0; i < s.Count; i++)
                {
                    dao_nv.XoaNVTrongTour(s[i]);
                }
                dao_nv.XoaNV(maNV);

                return 1;
            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }    

    }
}
