using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDuLich.DAO
{
    class DAO_Tour
    {
        DULICHEntiti db;
        public DAO_Tour()
        {
            db = new DULICHEntiti();
        }

        public List<Tour> List_Tour()
        {
            List<Tour> t = db.Tours.Where(p=>p.TinhTrang == 1).ToList();
            return t;
        }

        public List<Tour> List_TourQL()
        {
            List<Tour> t = db.Tours.ToList();
            return t;
        }

        public dynamic List_TourSDT()
        {
            var t = db.Tours.Where(p => p.TinhTrang == 1).ToList();
            return t;
            
        }
        public dynamic List_DiemDen()
        {
            var kq = db.Tours.Select(p => p.LichTrinhTour.Tinh).Distinct().ToList();
            return kq;
        }

        public dynamic List_KhoiHanh()
        {
            var kq = db.Tours.Select(p => p.DiemKhoiHanh).Distinct().ToList();
            return kq;
        }
        public List<Tour> change(String noiKH, String diemDen, int gia, int tt ,DateTime ngayKH)
        {
            List<Tour> t = null;
            if (gia == 1)
            {
                if(tt == 1)
                    t = db.Tours.Where(p => p.DiemKhoiHanh == noiKH && p.NgayKhoiHanh >= ngayKH && p.LichTrinhTour.Tinh == diemDen && p.TinhTrang == 1 && p.SoLuongVe>p.SoLuongDaDat).ToList();
                else
                    t = db.Tours.Where(p => p.DiemKhoiHanh == noiKH && p.NgayKhoiHanh >= ngayKH && p.LichTrinhTour.Tinh == diemDen && p.TinhTrang == 1 && p.SoLuongVe == p.SoLuongDaDat).ToList();

            }
            else if (gia == 0)
            {
                if (tt == 1)
                    t = db.Tours.Where(p => p.DiemKhoiHanh == noiKH && p.NgayKhoiHanh >= ngayKH && p.LichTrinhTour.Tinh == diemDen && p.TinhTrang == 1 && p.SoLuongVe > p.SoLuongDaDat).OrderByDescending(p => p.GiaVeNguoiLon).ToList();

                else
                    t = db.Tours.Where(p => p.DiemKhoiHanh == noiKH && p.NgayKhoiHanh >= ngayKH && p.LichTrinhTour.Tinh == diemDen && p.TinhTrang == 1 && p.SoLuongVe == p.SoLuongDaDat).OrderByDescending(p => p.GiaVeNguoiLon).ToList();


            }


            return t;
            
        }

     
        public Tour getTour(String maTour)
        {
            Tour t = db.Tours.Where(p => p.MaTour == maTour).FirstOrDefault();
            return t;
        }

        public bool CheckLichTrinhTour(String LichTrinh)
        {
            Tour t = db.Tours.Where(p=>p.MaLichTrinh == LichTrinh).FirstOrDefault();
            if (t != null)
                return true;
            return false;

        }

        public void XoaTourTheoLichTrinh(String maLichTrinh)
        {
            List<Tour> t = db.Tours.Where(p => p.MaLichTrinh == maLichTrinh).ToList();   
            db.Tours.RemoveRange(t);
            db.SaveChanges();
          
        }

        public List<String> DSMaTour(String maLichTrinh)
        {
            List<Tour> t = db.Tours.Where(p => p.MaLichTrinh == maLichTrinh).ToList();
            List<String> s = new List<string>();
            foreach (Tour h in t)
            {
                s.Add(h.MaTour);
            }
            return s;
        }

        public bool CheckNVTrongTour(String maNV)
        {
            Tour t = db.Tours.Where(p => p.NguoiDieuHanh == maNV).FirstOrDefault();
            if (t != null)
                return true;
            return false;

        }
        public void XoaTour_NV(String maNV)
        {
            List<Tour> t = db.Tours.Where(p => p.NguoiDieuHanh == maNV).ToList();
            db.Tours.RemoveRange(t);
            db.SaveChanges();
        }

   
        public List<String> DSMaTour_NV(String maNV)
        {
            List<String> t = db.Tours.Where(p => p.NguoiDieuHanh == maNV).Select(p => p.MaTour).ToList();
            return t;

        }

        public void ThemTour(Tour t)
        {
            db.Tours.Add(t);
            db.SaveChanges();
        }

        public void SuaTour(Tour k)
        {
            Tour t = db.Tours.Where(p => p.MaTour == k.MaTour).FirstOrDefault();
            t.MaTour = k.MaTour;
            t.NgayKhoiHanh = k.NgayKhoiHanh;
            t.MaLichTrinh = k.MaLichTrinh;
            t.NgayVe = k.NgayVe;
            t.NguoiDieuHanh = k.NguoiDieuHanh;
            t.GiaVeNguoiLon = k.GiaVeNguoiLon;
            t.GiaVeTreEm = k.GiaVeTreEm;
            t.SoLuongVe = k.SoLuongVe;
            t.DiemKhoiHanh = k.DiemKhoiHanh;
            db.SaveChanges();

        }

        public bool CheckTour(String k)
        {
            Tour t = db.Tours.Where(p => p.MaTour == k).FirstOrDefault();
            if (t != null)
                return true;
            return false;
        }

        public void XoaTour(String maTour)
        {
            Tour s = db.Tours.Where(p => p.MaTour == maTour).FirstOrDefault();
            db.Tours.Remove(s);
            db.SaveChanges();
          
        }

        public bool KtSoLuongVe(String maTour, int TongVe)
        {
            Tour t = db.Tours.Where(p => p.MaTour == maTour && p.SoLuongVe >= p.SoLuongDaDat + TongVe).FirstOrDefault();
            if (t != null)
                return true;
            return false;
        }

      

    }
}
