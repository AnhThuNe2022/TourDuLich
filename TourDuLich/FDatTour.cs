using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourDuLich.BUS;

namespace TourDuLich
{
    public partial class FDatTour : Form
    {
        public FDatTour()
        {
            InitializeComponent();
        }
        BUS_Tour bus_tour = new BUS_Tour();
        BUS_SoDatTour bus_dt = new BUS_SoDatTour();
        public Tour t;
        public KH khachhang;
        BUS_ChiTietDatVe bus_ct = new BUS_ChiTietDatVe();
        static String path = Application.StartupPath + @"\image\";
      
        private void FDatTour_Load(object sender, EventArgs e)
        {
            this.txtTenKH.Text = khachhang.TenKH;
            show();
            TinhTien();
            this.numNL.ValueChanged += ValueChanged;
            this.numTE.ValueChanged += ValueChanged;
            this.numSoPhong.ValueChanged += ValueChanged;
            
        }

        private void ValueChanged(object sender, EventArgs e)
        {

            TinhTien();

        }

        private int TinhTien()
        {
            int sLTE = Convert.ToInt32(this.numTE.Value);
            int sLNL = Convert.ToInt32(this.numNL.Value);
            int sLPhong = Convert.ToInt32(this.numSoPhong.Value);
            int giaTE = int.Parse(t.GiaVeTreEm.ToString().Split('.')[0]);
            int giaNL = int.Parse(t.GiaVeNguoiLon.ToString().Split('.')[0]);
            int giaPhong = int.Parse(t.LichTrinhTour.TienKS.ToString().Split('.')[0]);
            int tt = sLTE * giaTE + sLNL * giaNL + sLPhong * giaPhong;
            this.txtTongTien.Text = String.Format("{0:0,0 VND}", tt);
            this.txtTongTien.AutoSize = true;

            return tt;
        }

        private void show()
        {
            int giaNL = int.Parse(t.GiaVeNguoiLon.ToString().Split('.')[0]);
            this.txtGiaNguoiLon.Text = "Giá Người Lớn: " + String.Format("{0:0,0 VND}", giaNL);

            this.txtMaTour.Text = "Mã Tour: " + t.MaTour;
            this.txtNgayDi.Text= "Ngày Đi: " + String.Format("{0:dd/MM/yyyy}", t.NgayKhoiHanh);
            TimeSpan soNgayDi = (TimeSpan)(t.NgayVe - t.NgayKhoiHanh);
            this.txtSoNgay.Text = "Số Ngày: " + soNgayDi.Days;
            int giaTE = int.Parse(t.GiaVeTreEm.ToString().Split('.')[0]);

            this.txtGiaTreEm.Text = "Giá Trẻ Em: " + String.Format("{0:0,0 VND}", giaTE);
            int giaPhong = int.Parse(t.LichTrinhTour.TienKS.ToString().Split('.')[0]);
            this.txtPhong.Text = "Tiền Phòng : " + String.Format("{0:0,0 /Phòng}",giaPhong );
            this.txtpic.Image = Image.FromFile(path +t.LichTrinhTour.Picture);
           this.picMa.Image = Image.FromFile(path + "maTour.png");
            this.picNgay.Image = Image.FromFile(path + "Lich.png");
            this.picSoNgay.Image = Image.FromFile(path + "DongHo.png");
            this.picNL.Image = Image.FromFile(path + "gia.png");
            this.picTE.Image = Image.FromFile(path + "gia.png");
            this.picTienPhong.Image = Image.FromFile(path + "gia.png");
            this.txtHeading.Text = t.LichTrinhTour.TenCacDiaDanh;
            

        }

    
        private void picTE_Click(object sender, EventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            int kh = khachhang.MaKH;
            int kt = bus_dt.kiemTraKHDatTour(kh,t.MaTour);
            if (kt == 1)
            {
               DialogResult r = MessageBox.Show("Xác Nhận Đặt Tour Này Với Giá :" + txtTongTien.Text, "Xác Nhận",MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {//SoDatTour
                    SoDatTour st = new SoDatTour();
                    st.MaDon = MaSoDatTour();
                    st.MaTour = t.MaTour;
                    st.MaKH = kh;
                    st.SoPhong = Convert.ToInt32(this.numSoPhong.Value);
                    //st.TongTien = TinhTien();
                    st.NgayDat = DateTime.Now;
                    //ChiTiet

                    int slTE = Convert.ToInt32(this.numTE.Value);
                    int slNL = Convert.ToInt32(this.numNL.Value);

                    List<ChiTietDatVe> ct = new List<ChiTietDatVe>();
                    int maSo = MaSoChiTiet();
                    for (int i = 0; i < slNL; i++)
                    {
                        ChiTietDatVe v = new ChiTietDatVe();
                        v.MaVe = "CT" + maSo;
                        maSo++;
                        v.MaDonHang = st.MaDon;
                        v.LoaiVe = 1;
                        ct.Add(v);
                    }

                    for (int i = 0; i < slTE; i++)
                    {
                        ChiTietDatVe v = new ChiTietDatVe();
                        v.MaVe = "CT" + maSo;
                        maSo++;
                        v.MaDonHang = st.MaDon;
                        v.LoaiVe = 2;
                        ct.Add(v);
                    }

                    int m = bus_dt.Dat_Tour(st, ct);
                    if (m == 1)
                    {
                        MessageBox.Show("Đặt Thành Công!");
                        //FGioHang f = new FGioHang();
                        //f.khachHang = this.khachhang;
                        //f.Show();
                    }

                    else if (m == -3)
                        MessageBox.Show("Số Lượng Vé Không Đủ Cho Bạn");
                    else
                        MessageBox.Show("Đặt Thất Bại");

                }
            
            }
            else if (kt == 0)
            {
                MessageBox.Show("Không tồn tại mã khách hàng");
            }
            else
            {
                DialogResult r1 = MessageBox.Show("Bạn Đã Đặt Tour Này Trước Đó Có Muốn Đặt Tiếp Không?","Xác Nhận", MessageBoxButtons.YesNo);
                if (r1 == DialogResult.Yes)
                {

                    //SoDatTour
                    SoDatTour st = new SoDatTour();
                    st.MaDon = MaSoDatTour();
                    st.MaTour = t.MaTour;
                    st.MaKH = kh;
                    st.SoPhong = Convert.ToInt32(this.numSoPhong.Value);
                    st.TongTien = TinhTien();
                    st.NgayDat = DateTime.Now;
                    //ChiTiet

                    int slTE = Convert.ToInt32(this.numTE.Value);
                    int slNL = Convert.ToInt32(this.numNL.Value);

                    List<ChiTietDatVe> ct = new List<ChiTietDatVe>();
                    int maSo = MaSoChiTiet();
                    for (int i = 0; i < slNL; i++)
                    {
                        ChiTietDatVe v = new ChiTietDatVe();
                        v.MaVe = "CT" + maSo;
                        maSo++;
                        v.MaDonHang = st.MaDon;
                        v.LoaiVe = 1;
                        ct.Add(v);
                    }

                    for (int i = 0; i < slTE; i++)
                    {
                        ChiTietDatVe v = new ChiTietDatVe();
                        v.MaVe = "CT" + maSo;
                        maSo++;
                        v.MaDonHang = st.MaDon;
                        v.LoaiVe = 2;
                        ct.Add(v);
                    }

                    int m = bus_dt.Dat_Tour(st, ct);
                    if ( m == 1)
                        MessageBox.Show("Đặt Thành Công!");
                    else if (m == -3)
                        MessageBox.Show("Số Lượng Vé Không Đủ Cho Bạn");
                    else
                        MessageBox.Show("Đặt Thất Bại");

                }

            }    
              
        }

        private String MaSoDatTour()
        {
            String ma = bus_dt.GetLast();
            int m;
            if (ma == "0")
                m = 0;
            else
                m = int.Parse(ma.Substring(1));
            m++;
            return "D" + m.ToString();
          
        }

        private int MaSoChiTiet()
        {
            String ma = bus_ct.GetLastChiTiet();
            int m;
            if (ma == "0")
                m = 0;
            else
                m = int.Parse(ma);
            m++;
            return m; 

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
