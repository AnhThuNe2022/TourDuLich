using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDuLich.DAO
{
    class DAO_LichTrinh
    {
        DULICHEntiti db;
        public DAO_LichTrinh()
        {
            db = new DULICHEntiti();
        }

        public List<LichTrinhTour> List_LichTrinh()
        {
            List<LichTrinhTour> l = db.LichTrinhTours.ToList();
            return l;
        }

        public void ThemLichTrinh(LichTrinhTour l)
        {
            db.LichTrinhTours.Add(l);
            db.SaveChanges();
        }
        public LichTrinhTour GetLast()
        {
            LichTrinhTour l = db.LichTrinhTours.OrderByDescending(p => p.NgayCapNhatGanNhat).FirstOrDefault();
            return l;
        }

        public void SuaLichTrinh(LichTrinhTour l)
        {
            LichTrinhTour k = db.LichTrinhTours.Where(p => p.MaLichTrinh == l.MaLichTrinh).FirstOrDefault();
            k.MaLichTrinh = l.MaLichTrinh;
            k.KhachSan = l.KhachSan;
            k.Picture = l.Picture;
            k.TienKS = l.TienKS;
            k.Tinh = l.Tinh;
            k.MoTaLichTrinh = l.MoTaLichTrinh;
            k.TenCacDiaDanh = l.TenCacDiaDanh;
            k.NgayCapNhatGanNhat = l.NgayCapNhatGanNhat;
            db.SaveChanges();
        }

        public bool CheckLichTrinh(String ma)
        {
            LichTrinhTour k = db.LichTrinhTours.Where(p => p.MaLichTrinh == ma).FirstOrDefault();
            if (k != null)
                return true;
            return false;
        }

        public void XoaLichTrinh(String ma)
        {
            LichTrinhTour l = db.LichTrinhTours.Where(p => p.MaLichTrinh == ma).FirstOrDefault();
            db.LichTrinhTours.Remove(l);
            db.SaveChanges();
        }


    }
}
