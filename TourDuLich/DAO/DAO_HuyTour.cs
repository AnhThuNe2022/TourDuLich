using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TourDuLich.DAO
{
    class DAO_HuyTour
    {

        DULICHEntiti db;
        public DAO_HuyTour()
        {
            db = new DULICHEntiti();
        }


        public void themHuyTour(HuyTour ht)
        {
            db.HuyTours.Add(ht);
            db.SaveChanges();
        }

        public HuyTour GetLast()
        {
            HuyTour st = db.HuyTours.OrderByDescending(p => p.NgayHuy).FirstOrDefault();
            return st;
        }


        public bool KiemTraMaVe(String maVe)
        {
            HuyTour k = db.HuyTours.Where(p => p.MaVe == maVe).FirstOrDefault();
            if (k != null)
            {
                return true;
            }
            else
                return false;
        }

        public void XoaHuyTourTheoChiTiet(String maVe)
        {
            HuyTour h = db.HuyTours.Where(p => p.MaVe == maVe).FirstOrDefault();
            db.HuyTours.Remove(h);
            db.SaveChanges();
        }

        public bool checkChiTietTrongHuyTour(String maVe)
        {
            HuyTour h = db.HuyTours.Where(p => p.MaVe == maVe).FirstOrDefault();
            if (h != null)
                return true;
            return false;
        }

        public dynamic List_HuyTour()
        {
            var h = db.HuyTours.Select(p=>new
            {
                p.MaHuyTour,
                p.MaVe,
                p.NgayHuy
            }).ToList();
            return h;
        }

        public void XoaHuyTour(String maHuy)
        {
            HuyTour t = db.HuyTours.Where(p => p.MaHuyTour == maHuy).FirstOrDefault();
            db.HuyTours.Remove(t);
            db.SaveChanges();
        }
        public bool KTMaHT(String maHuy)
        {
            HuyTour t = db.HuyTours.Where(p => p.MaHuyTour == maHuy).FirstOrDefault();
            if (t != null)
                return true;
            return false;
        }

        public bool KTMaVeDuyNhat(String maVe)
        {
            HuyTour t = db.HuyTours.Where(p => p.MaVe == maVe).FirstOrDefault();
            if (t == null)
                return true;
            return false;
        }

       //public void KhoiPhucVe(String Ve)
       // {
       //     db.KhoiPhucVe(Ve);
       // }
       

       



        //public bool KiemTraMaHuyDon(String maHuyDon)
        //{
        //    //maHuyDon hd = 
        //}


    }
}
