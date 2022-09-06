using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDuLich.DAO
{
    class DAO_ChiTietDonHang
    {
        DULICHEntiti db;
        public DAO_ChiTietDonHang()
        {
            db = new DULICHEntiti();
        }

        public List<ChiTietDatVe> GetLast_List(String maDH)
        {
            List<ChiTietDatVe> ct = db.ChiTietDatVes.OrderByDescending(p => p.SoDatTour.MaDon == maDH).ToList();
            return ct;
        }
        public void themChiTiet(ChiTietDatVe v)
        {
            db.ChiTietDatVes.Add(v);
            db.SaveChanges();

        }

        public bool KTMaChiTiet(String maChiTiet)
        {
            ChiTietDatVe d = db.ChiTietDatVes.Where(p => p.MaVe == maChiTiet).FirstOrDefault();
            if (d == null)
            {
                return true;
            }
            else
                return false;
        }

        public List<ChiTietDatVe> List_CTDV(int maKH)
        {
            List<ChiTietDatVe> ct = db.ChiTietDatVes.Where(p => p.SoDatTour.MaKH == maKH).ToList();

            return ct;
        }
        public bool KtChiTiet(int maKH)
        {
            ChiTietDatVe ct = db.ChiTietDatVes.Where(p => p.SoDatTour.MaKH == maKH).FirstOrDefault();
            if (ct != null)
                return true;
            return false;
        }
        public bool KtMaVe(String maVe)
        {
            ChiTietDatVe v = db.ChiTietDatVes.Where(p => p.MaVe == maVe).FirstOrDefault();
            if (v != null)
                return true;
            else
                return false;
        }

        public void XoaChiTietTheoDonHang(String maDonHang)
        {
            List<ChiTietDatVe> ct = db.ChiTietDatVes.Where(p => p.MaDonHang == maDonHang).ToList();
            db.ChiTietDatVes.RemoveRange(ct);
            db.SaveChanges();
        }

        public List<String> DSMaChiTiet(String maDonHang)
        {
            List<ChiTietDatVe> ct = db.ChiTietDatVes.Where(p => p.MaDonHang == maDonHang).ToList();
            List<String> s = new List<string>();
            foreach (ChiTietDatVe h in ct)
            {
                s.Add(h.MaVe);
            }
            return s;
        }

        public List<ChiTietDatVe> List_ChiTietTheoMaDH(String maDonHang)
        {
            List<ChiTietDatVe> ct = db.ChiTietDatVes.Where(p => p.MaDonHang == maDonHang).ToList();
            return ct;
        }

        public dynamic List_ChiTiet()
        {
            var k = db.ChiTietDatVes.Select(p => p.MaDonHang).ToList();
            return k;
        }

        public void XoaListChiTiet(String v)
        {
            ChiTietDatVe k = db.ChiTietDatVes.Where(p => p.MaVe == v).FirstOrDefault();
            db.ChiTietDatVes.Remove(k);
            db.SaveChanges();
        }
        public String GetMaDh(String maCT)
        {
            String s = db.ChiTietDatVes.Where(p => p.MaVe == maCT).Select(p => p.MaDonHang).FirstOrDefault();
            return s;
        }


    }
}
