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
    public partial class FXemTour : Form
    {
        public FXemTour()
        {
            InitializeComponent();
        }
        public String maTour = "T4";
        public KH khachHang;
        BUS_Tour bus_tour = new BUS_Tour();
        private Tour tour = new Tour();
        static String path = Application.StartupPath + @"\image\";
        List<TourDL> tourDL = new List<TourDL>();
        int[] n;


        private void FXemTour_Load(object sender, EventArgs e)
        {
            this.txtTenKH.Text = khachHang.TenKH;
           
            
            kiemTra();
            groupbox();
            n = new int[this.tourDL.Count];
            for (int i = 0; i < this.tourDL.Count ; i++)
            {
                n[i] = 0;
            }
             for (int i = 0; i < tourDL.Count; i++)
            {
                this.tourDL[i].getText().Click += FXemTour_Click;
            }    
        }

        private void FXemTour_Click(object sender, EventArgs e)
        {
            Label t = (Label)sender;
            int i = int.Parse(t.Name) - 1;
           if( this.n[i] == 0)
            {
                t.MaximumSize = new Size(t.Width, 0);
                t.AutoSize = true;
                this.n[i] = 1;
            }    
           else
            {
                t.Size = new System.Drawing.Size(470, 175);
                t.AutoSize = false;
                this.n[i] = 0;
            }    
         
            
            this.tourDL[i].gb.Size = new System.Drawing.Size(663, t.Height + 70);
            this.tourDL[i].getHeading().Location = new System.Drawing.Point(0, (this.tourDL[i].gb.Height) / 2 - 10);
            int toaDoY;
            for (int j = i + 1; j < this.tourDL.Count; j++)
            {
                toaDoY = this.tourDL[j - 1].gb.Size.Height + this.tourDL[j - 1].gb.Location.Y + 20;
                this.tourDL[j].gb.Location = new System.Drawing.Point(483, toaDoY);
            }
        }

        private void groupbox()
        {
            int ToaDoY = 134;
            String text = tour.LichTrinhTour.MoTaLichTrinh;
            String [] list_text = text.Split('^');


            for (int i = 0; i < list_text.Length-1; i++)
            {

                Label[] Text = new Label[3];
                for (int j = 0; j < Text.Length; j++)
                    Text[j] = new Label();

                String[] list_text2 = list_text[i].Split('#');
                String[] moTa = list_text2[1].Split('@');
                String final = "";
                for (int k = 0; k < moTa.Length; k++ )
                {
                    final += moTa[k] + '\n';
                }    


                Text[0].Text = "Ngày " + (i + 1).ToString();
                Text[1].Text = list_text2[0];
                Text[2].Text = final;
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(path + "NoiKHDD.png");
               
                TourDL t = new TourDL(Text,p,ToaDoY);
                this.tourDL.Add(t);
                this.Controls.Add(t.gb);
                //ToaDoY += 250;          
                 ToaDoY = t.gb.Size.Height + t.gb.Location.Y + 20;
            }
        }

        private void show(Tour t)
        {
            this.txtNgayKH.Text = String.Format("{0:dd/MM/yyyy}",t.NgayKhoiHanh);
            this.txtNoiKhoiHanh.Text = t.DiemKhoiHanh;
            TimeSpan soNgayDi = (TimeSpan)(t.NgayVe - t.NgayKhoiHanh);
            this.txtSoNgay.Text = (soNgayDi.Days ).ToString() + " Ngày";
            int giaNL = int.Parse(t.GiaVeNguoiLon.ToString().Split('.')[0]);
          
            this.txtVeNguoiLon.Text = String.Format("{0:0,0 VND}", giaNL);
            int giaTE = int.Parse(t.GiaVeTreEm.ToString().Split('.')[0]);
            this.txtVeTreEm.Text = String.Format("{0:0,0 VND}", giaTE);
            this.txtSoChoCon.Text = (t.SoLuongVe - t.SoLuongDaDat).ToString() + " Chỗ";

        }

        private void kiemTra()
        {
            int kt = bus_tour.showTour(this.maTour, ref this.tour);
            if (kt == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
            }
            else if (kt == -1)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                show(this.tour);
                this.txtTenTour.Text = tour.LichTrinhTour.TenCacDiaDanh;
                this.picTour.Image = Image.FromFile(path + tour.LichTrinhTour.Picture);
            }    
              
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void xem_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {
            FDatTour f = new FDatTour();
            f.t = this.tour;
            f.khachhang = this.khachHang;
            f.Show();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoNgay_Click(object sender, EventArgs e)
        {

        }
    }
}
