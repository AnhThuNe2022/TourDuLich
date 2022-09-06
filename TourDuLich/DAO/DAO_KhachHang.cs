using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDuLich.DAO
{
    class DAO_KhachHang
    {
        DULICHEntiti db;
        public DAO_KhachHang()
        {
            db = new DULICHEntiti();
        }

        public bool kiemTraKH(int maKH)
        {
            KH k = db.KHs.Where(p => p.MaKH == maKH).FirstOrDefault();
            if(k!= null)
            {
                return true;
            }
            return false;

        }

        public KH FindKH(decimal sđt, String mk)
        {
            KH k = db.KHs.Where(p => p.SĐT == sđt && p.MatKhau == mk).FirstOrDefault();
            return k;
        }
        public dynamic List_KH()
        {
            var k = db.KHs.Select(p => new
            {
                p.MaKH,
                p.TenKH,
                p.DiaChi,
                p.GioiTinh,
                p.NgaySinh,
                p.SĐT
            }).ToList();
            return k; 
        }
        public void ThemKH(KH KhachHang)
        {
            db.KHs.Add(KhachHang);
            db.SaveChanges();
        }    
        public bool CheckSDT(String SDT)
        {
            KH k = db.KHs.Where(p => p.SĐT.ToString() == SDT).FirstOrDefault();
            if (k != null)
                return true;
            return false;
        }

        public bool CheckSDT2(int maKH,String SDT)
        {
            KH k = db.KHs.Where(p => p.SĐT.ToString() == SDT && p.MaKH != maKH).FirstOrDefault();
            if (k != null)
                return true;
            return false;
        }

        public void SuaKH(KH d)
        {
            KH k = db.KHs.Where(p => p.MaKH == d.MaKH).FirstOrDefault();
            k.MaKH = d.MaKH;
            k.TenKH = d.TenKH;
            k.NgaySinh = d.NgaySinh;
            k.DiaChi = d.DiaChi;
            k.SĐT = d.SĐT;
            k.GioiTinh = d.GioiTinh;
            db.SaveChanges();

        }

        public void XoaKH(int maKH)
        {
            KH k = db.KHs.Where(p => p.MaKH == maKH).FirstOrDefault();
            db.KHs.Remove(k);
            db.SaveChanges();
        }    


    }
}
