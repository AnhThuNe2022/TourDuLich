using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TourDuLich.DAO
{
    class DAO_SoDatTour
    {
        DULICHEntiti db;
        public DAO_SoDatTour()
        {
            db = new DULICHEntiti();
        }

        public bool KiemTraKHDatTour(int maKH,String maTour)
        {
            SoDatTour k = db.SoDatTours.Where(p => p.MaKH == maKH && p.MaTour == maTour).FirstOrDefault();
            if (k == null)
                return false;
            return true;
        }
        public void DatTour(SoDatTour s)
        {
            db.SoDatTours.Add(s);
            db.SaveChanges();
            
        }

        public SoDatTour GetLast()
        {
            SoDatTour st = db.SoDatTours.OrderByDescending(p => p.NgayDat).FirstOrDefault();
            return st;
        }

        public void XoaSoDatTourTheoTour(String maTour)
        {
            List<SoDatTour> s = db.SoDatTours.Where(p => p.MaTour == maTour).ToList();
            db.SoDatTours.RemoveRange(s);
            db.SaveChanges();
        }
        public void XoaSoDatTourTheoKH(int maKH)
        {
            List<SoDatTour> s = db.SoDatTours.Where(p => p.MaKH == maKH).ToList();
            db.SoDatTours.RemoveRange(s);
            db.SaveChanges();
        }


        public List<String> DSMaDonHang(String maTour)
        {
            List<SoDatTour> t = db.SoDatTours.Where(p => p.MaTour == maTour).ToList();
            List<String> s = new List<string>();
            foreach (SoDatTour h in t)
            {
                s.Add(h.MaDon);
            }
            return s;
        }
        public List<String> DSMaDonHangTheoKH(int maKH)
        {
            List<SoDatTour> t = db.SoDatTours.Where(p => p.MaKH == maKH).ToList();
            List<String> s = new List<string>();
            foreach (SoDatTour h in t)
            {
                s.Add(h.MaDon);
            }
            return s;
        }

        //public bool KTSoLuongVe(List<ChiTietDatVe> v,String maTour)
        //{
        //    var k = db.ChiTietDatVes.Where(p => p.SoDatTour.MaTour == maTour && p.SoDatTour.Tour.SoLuongVe >= p.SoDatTour.Tour.SoLuongDaDat + v.Count ).FirstOrDefault();
        //    if (k != null)
        //        return true;
        //    //int k1 = db.ChiTietDatVes.Where(p => p.SoDatTour.MaTour == maTour).Select(p => p.SoDatTour.Tour.SoLuongVe);
        //    //Chi k2 = db.ChiTietDatVes.Where(p => p.SoDatTour.MaTour == maTour).Select(p => p.SoDatTour.Tour.SoLuongDaDat + v.Count).ToString();
        //    MessageBox.Show(v.Count.ToString() );
        //    MessageBox.Show(maTour);
        //    return false;
           
        //}

        public bool KiemTraKH_SoDat(int maKH)
        {
            SoDatTour k = db.SoDatTours.Where(p => p.MaKH == maKH).FirstOrDefault();
            if (k != null)
                return true;
            return false;
        }    
        public bool KiemTraTour_SoDat(String maTour)
        {
            SoDatTour k = db.SoDatTours.Where(p => p.MaTour == maTour).FirstOrDefault();
            if (k != null)
                return true;
            return false;
        }

        public dynamic List_SoDatTour()
        {
            var t = db.SoDatTours.Select(p => new
            {
                p.MaDon,
                p.MaKH,
                p.MaTour,
                p.SoPhong,
                p.NgayDat,
                p.TongTien
            }).ToList();
            return t;

        }

        public void SuaDonHang(SoDatTour k)
        {
            SoDatTour s = db.SoDatTours.Where(p => p.MaDon == k.MaDon).FirstOrDefault();
            s.MaDon = k.MaDon;
            s.MaKH = k.MaKH;
            s.MaTour = k.MaTour;
            s.SoPhong = k.SoPhong;
            s.NgayDat = k.NgayDat;
            db.SaveChanges();
        }

        public bool CheckDonHang(String maDH)
        {
            SoDatTour s = db.SoDatTours.Where(p => p.MaDon == maDH).FirstOrDefault();
            if (s != null)
                return true;
            return false;
        }

        public void XoaDonHang(String maDH)
        {
            SoDatTour t = db.SoDatTours.Where(p => p.MaDon == maDH).FirstOrDefault();
            db.SoDatTours.Remove(t);
            db.SaveChanges();
        }

        public void HoanChoHuyVe(String maDH)
        {
            String s = db.SoDatTours.Where(p => p.MaDon == maDH).Select(p => p.MaTour).FirstOrDefault();
            db.HoanChoHuyVe(s);
           
        }




    }
}
