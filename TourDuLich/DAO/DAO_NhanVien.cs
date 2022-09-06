using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDuLich.DAO
{
    class DAO_NhanVien
    {
        DULICHEntiti db;
        public DAO_NhanVien()
        {
            db = new DULICHEntiti();
        }

        public dynamic List_NhanVien()
        {
            var k = db.NhanViens.Select(p => new
            {
                p.MaNhanVien,
                p.TenNhanVien,
                p.NgaySinh,
                p.GioiTinh,
                p.DiaChi,
                p.ChucVu,
                p.SĐT

            }).ToList();
            return k;
        }

        public List<String> GetMaNV()
        {
            List<String> s = db.NhanViens.Select(p => p.MaNhanVien).ToList();
            return s;
        }

        public void themNV (NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        public NhanVien FindNV(decimal sdt,String mk)
        {
            NhanVien k = db.NhanViens.Where(p => p.SĐT == sdt && p.MatKhau == mk &&p.ChucVu == "Quản Lý").FirstOrDefault();
            return k;

        }
        public void SuaNV(NhanVien nv)
        {
            NhanVien n = db.NhanViens.Where(p => p.MaNhanVien == nv.MaNhanVien).FirstOrDefault();
            n.MaNhanVien = nv.MaNhanVien;
            n.GioiTinh = nv.GioiTinh;
            n.NgaySinh = nv.NgaySinh;
            n.SĐT = nv.SĐT;
            n.TenNhanVien = nv.TenNhanVien;
            n.DiaChi = nv.DiaChi;
            n.ChucVu = nv.ChucVu;
            db.SaveChanges();
        }
        public bool CheckNV(String maNV)
        {
            NhanVien n = db.NhanViens.Where(p => p.MaNhanVien == maNV).FirstOrDefault();
            if (n != null)
                return true;
            return false;
        }

        public void XoaNV(String maNV)
        {
            NhanVien s = db.NhanViens.Where(p => p.MaNhanVien == maNV).FirstOrDefault();
            db.NhanViens.Remove(s);
            db.SaveChanges();
        }    

        public List<NhanVien> GetNVDieuHanh_Tour()
        {
            List<NhanVien> nv = db.NhanViens.Where(p => p.ChucVu == "Hướng Dẫn Viên Du Lịch" || p.ChucVu == "Điều Hành Du Lịch").ToList();
            return nv;
        }
       
        public bool checkSDT(String SDT)
        {
            NhanVien s = db.NhanViens.Where(p => p.SĐT.ToString() == SDT).FirstOrDefault();
            if (s != null)
                return true;
            return false;
        }

        public bool checkSDT2(String maNV ,String SDT)
        {
            NhanVien s = db.NhanViens.Where(p => p.SĐT.ToString() == SDT && p.MaNhanVien != maNV).FirstOrDefault();
            if (s != null)
                return true;
            return false;
        }

        public void XoaNVTrongTour(String maTour)
        {
            db.XoaNVTrongTour(maTour);
            //Tour t = db.Tours.Where(p => p.MaTour == maTour).FirstOrDefault();
            //t.NguoiDieuHanh = null;
            db.SaveChanges();
        }
    }
}
