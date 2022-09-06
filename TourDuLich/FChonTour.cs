using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourDuLich.BUS;

namespace TourDuLich
{
    public partial class FChonTour : Form
    {
        public FChonTour()
        {
            InitializeComponent();
        }
        static String path = Application.StartupPath + @"\image\";
        BUS_Tour bus_tour = new BUS_Tour();
        public KH khachHang;

        private void icon()
        {
            picGia.Image = Image.FromFile(path + "gia.png");
            picKhoiHanh.Image = Image.FromFile(path + "NoiKHDD.png");
            picDiemDen.Image = Image.FromFile(path + "NoiKHDD.png");
            picTinhTrang.Image = Image.FromFile(path + "TinhTrang.png");
            picTuNgay.Image = Image.FromFile(path + "Lich.png");

        }
        private List<TourDL> ListTour = new List<TourDL>();

        private void FChonTour_Load(object sender, EventArgs e)
        {
            this.pnMenu.Visible = false;
            //this.MaximumSize = new Size(this.Width+15, int.MaxValue);
            this.picBack.Visible = false;

            this.txtHoTen.Text = khachHang.TenKH;
            this.icon();
            bus_tour.List_DiemKhoiHanh(cbNoiKhoiHanh);
            bus_tour.List_DiemDen(cbDiemDen);

            //this.groupbox(bus_tour.List_Tour());

        }


        private void FChonTour_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            FXemTour f = new FXemTour();
            f.maTour = lb.Name;
            f.khachHang = this.khachHang;
            f.Show();
        }

        private void groupbox(List<Tour> LTour)
        {
            int ToaDoY = 220;


            for (int i = 0; i < LTour.Count; i++)
            {

                Label[] Text = new Label[8];
                for (int j = 0; j < Text.Length; j++)
                    Text[j] = new Label();

                Text[0].Text = LTour[i].LichTrinhTour.TenCacDiaDanh;
                Text[1].Text = "Mã Tour: " + LTour[i].MaTour;
                Text[2].Text = "Ngày Đi: " + String.Format("{0:dd/MM/yyyy}", LTour[i].NgayKhoiHanh);
                int gia = int.Parse(LTour[i].GiaVeNguoiLon.ToString().Split('.')[0]);
                Text[3].Text = "Giá : " + String.Format("{0:0,0 VND}", gia);
                Text[4].Text = "Nơi Khởi Hành: " + LTour[i].DiemKhoiHanh;
                Text[5].Text = "Số Chỗ Còn Nhận: " + (LTour[i].SoLuongVe - LTour[i].SoLuongDaDat).ToString();
                Text[6].Text = "Giờ Đi : " + String.Format("{0:h.mm tt}", LTour[i].NgayKhoiHanh);
                TimeSpan soNgayDi = (TimeSpan)(LTour[i].NgayVe - LTour[i].NgayKhoiHanh);
                Text[7].Text = "Số Ngày: " + soNgayDi.Days;
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(path + LTour[i].LichTrinhTour.Picture);
                PictureBox stars = new PictureBox();
                stars.Image = Image.FromFile(path + "Sao.png");
                TourDL t = new TourDL(Text, stars, p, LTour[i].MaTour, ToaDoY);
                this.ListTour.Add(t);
                this.Controls.Add(t.gb);
                ToaDoY += 360;
            }
        }

        private List<Tour> Change_View()
        {
            String diemKH = cbNoiKhoiHanh.Text;
            String diemDen = cbDiemDen.Text;
            int gia = 0;
            int tinhTrang = 0;
            if (this.cbGia.Text == "Tăng Dần")
                gia = 1;
            if (this.cbTinhTrang.Text == "Còn Chỗ")
                tinhTrang = 1;
            DateTime time = dtpTuNgay.Value;
            return bus_tour.change(diemKH, diemDen, gia, tinhTrang, time);

        }






        private void btTimKiem_Click(object sender, EventArgs e)
        {

            List<Tour> t = Change_View();
       
            
            foreach (TourDL k in this.ListTour)
            {
                this.Controls.Remove(k.gb);
            }

            if (t.Count == 0)
            {

               
            }
            else
            {
              
                groupbox(t);
                foreach (TourDL i in ListTour)
                {
                    i.getHeading().Click += FChonTour_Click;
                }
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpTuNgay.Value < DateTime.Now)
            {
                MessageBox.Show("Không Thể Chọn Ngày Đã Qua");
                dtpTuNgay.Value = DateTime.Now;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.groupbox(bus_tour.List_Tour());
            this.pnMenu.Visible = true;
            this.pnChon.Visible = false;
            this.picBack.Visible = true;

            foreach (TourDL i in ListTour)
            {
                i.getHeading().Click += FChonTour_Click;
            }
        }

        private void btXemVe_Click(object sender, EventArgs e)
        {
            FGioHang f = new FGioHang();
            f.khachHang = khachHang;
            f.Show();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.pnMenu.Visible = false;
            this.pnChon.Visible = true;
            this.picBack.Visible = false;
            foreach (TourDL i in ListTour.ToList())
            {
                this.Controls.Remove(i.gb);
            }
        }

        private void pnChon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
