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
    public partial class FGioHang : Form
    {
        public FGioHang()
        {
            InitializeComponent();
        }
        static String path = Application.StartupPath + @"\image\";
        BUS_ChiTietDatVe bus_ct = new BUS_ChiTietDatVe();
        BUS_HuyTour bus_ht = new BUS_HuyTour();
      
        List<ChiTietDatVe> List_ct = new List<ChiTietDatVe>();
        List<TourDL> tourDL = new List<TourDL>();

        public KH khachHang;
        private void FGioHang_Load(object sender, EventArgs e)
        {
            this.show();
            this.txtKhachHang.Text = khachHang.TenKH;
        }


        private void FGioHang_Click(object sender, EventArgs e)
        {
            
            Label lb = (Label)sender;
            DialogResult r = MessageBox.Show("Bạn Có Chắc Là Muốn Hủy Vé Này Không? ", "Xác Nhận", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                HuyTour h = new HuyTour();
                h.MaHuyTour = MaSoDatTour();
                h.MaVe = lb.Name;
                h.NgayHuy = DateTime.Now;
                int k = bus_ht.Huy_Tour(h);
                if (k == 1)
                {
                    MessageBox.Show("Xóa Thành Công");
                 
                    foreach(TourDL a in tourDL)
                    {
                        this.Controls.Remove(a.gb);
                    }    
                    
                    tourDL.Clear();
                   

                    show();
                }
                else if (k == 0)
                {
                    MessageBox.Show("Không tìm thấy mã đơn hàng cần xóa");

                }
                else
                    MessageBox.Show("Lỗi hệ thống");
            }    
           



        }
        private String MaSoDatTour()
        {
            String ma = bus_ht.GetLast();
            int m;
            if (ma == "0")
                m = 0;
            else
                m = int.Parse(ma.Substring(1));
            m++;
            return "H" + m.ToString();

        }

        private void show()
        {
            int maKH = khachHang.MaKH;
            int k = bus_ct.List_CTDV(maKH, ref this.List_ct);
            if (k == 1)
            {
                List<Tour> t = bus_ct.List_TourCT(this.List_ct);
                if (t != null)
                {
                    this.groupbox(t);
                    for (int i = 0; i < tourDL.Count; i++)
                    {
                        tourDL[i].GetXoa().Click += FGioHang_Click;
                    }
                }
                else
                    MessageBox.Show("Lỗi");
 
            }
            else if (k == 0)
            {
                MessageBox.Show("Khách Hàng Chưa Đặt Vé Nào Cả");
                
               
         

            }
            else 
                MessageBox.Show("Lỗi Hệ Thống");


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
                Text[3].Text = "Nơi Khởi Hành: " + LTour[i].DiemKhoiHanh; /*"Giá : " + String.Format("{0:0,0 VND}", gia);*/
                Text[4].Text = "Giờ Đi : " + String.Format("{0:h.mm tt}", LTour[i].NgayKhoiHanh);
                String LoaiVe;
                int tongGia;
                if (this.List_ct[i].LoaiVe == 1)
                {
                    LoaiVe = "Người Lớn";
                    tongGia = int.Parse(LTour[i].GiaVeNguoiLon.ToString().Split('.')[0]);
                }
                else
                {
                    LoaiVe = "Trẻ Em";
                    tongGia = int.Parse(LTour[i].GiaVeTreEm.ToString().Split('.')[0]);
                }
                   
            
                Text[5].Text = "Loại Vé: " + LoaiVe;
                Text[6].Text = "Giá: " + String.Format("{0:0,0 VND}", tongGia); 
                 TimeSpan soNgayDi = (TimeSpan)(LTour[i].NgayVe - LTour[i].NgayKhoiHanh);
                Text[7].Text = "Số Ngày: " + soNgayDi.Days;
                    
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(path + LTour[i].LichTrinhTour.Picture);
                PictureBox stars = new PictureBox();
                stars.Image = Image.FromFile(path + "Sao.png");
                PictureBox xoa = new PictureBox();
                xoa.Image = Image.FromFile(path + "xoa.png");
                TourDL t = new TourDL(Text, stars, p, xoa , List_ct[i].MaVe, ToaDoY);
                this.tourDL.Add(t);
                this.Controls.Add(t.gb);
                ToaDoY += 360;
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
