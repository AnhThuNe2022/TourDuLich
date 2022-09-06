using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourDuLich.BUS;

namespace TourDuLich.FormQuanLy
{
    public partial class FLichTrinh : Form
    {
        public FLichTrinh()
        {
            InitializeComponent();
        }
        BUS_LichTrinh bus_lt = new BUS_LichTrinh();
        static String path = Application.StartupPath + @"\image\pic\";
        private void gVLichTrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FLichTrinh_Load_1(object sender, EventArgs e)
        {
   
            this.pnMoTa.Visible = false;
            string[] img = Directory.GetFiles(path);
            foreach (String i in img)
            {
                this.cbPic.Items.Add(i);
            }
            if (bus_lt.List_LichTrinh(this.gVLichTrinh) == 0)
            {
                MessageBox.Show("Lỗi hệ thống");

            }
            DinhDangF.setDataGridView(this.gVLichTrinh);
            SetColum();

        }

        private void SetColum()
        {
            this.gVLichTrinh.Columns[0].Width = (int)(this.gVLichTrinh.Width * 0.05);
            this.gVLichTrinh.Columns[1].Width = (int)(this.gVLichTrinh.Width * 0.40);
            this.gVLichTrinh.Columns[2].Width = (int)(this.gVLichTrinh.Width * 0.12);
            this.gVLichTrinh.Columns[3].Width = (int)(this.gVLichTrinh.Width * 0.075);
            this.gVLichTrinh.Columns[4].Width = (int)(this.gVLichTrinh.Width * 0.1);
            this.gVLichTrinh.Columns[5].Width = (int)(this.gVLichTrinh.Width * 0.15);
            this.gVLichTrinh.Columns[6].Width = (int)(this.gVLichTrinh.Width * 0.12);
        }

        private void gVLichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.gVLichTrinh.Rows.Count)
            {
               
                //Mã
                if (this.gVLichTrinh.Rows[e.RowIndex].Cells[0].Value is null)
                    this.txtMa.Text = String.Empty;
                else
                    txtMa.Text = this.gVLichTrinh.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Ten Dia Danh
                if (this.gVLichTrinh.Rows[e.RowIndex].Cells[1].Value is null)
                    this.txtTenDiaDanh.Text = String.Empty;
                else         
                    txtTenDiaDanh.Text = this.gVLichTrinh.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Tỉnh
                if (this.gVLichTrinh.Rows[e.RowIndex].Cells[2].Value is null)
                    this.cbTinh.Text = String.Empty;
                else
                    cbTinh.Text = this.gVLichTrinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                //Khách Sạn
                if (this.gVLichTrinh.Rows[e.RowIndex].Cells[3].Value is null)
                    this.txtTenKS.Text = String.Empty;
                else
                    txtTenKS.Text = this.gVLichTrinh.Rows[e.RowIndex].Cells[3].Value.ToString();
                
                //Phi Phòng
                if (this.gVLichTrinh.Rows[e.RowIndex].Cells[4].Value is null)
                    this.txtPhiPhong.Text = String.Empty;
                else
                {
                    String money = this.gVLichTrinh.Rows[e.RowIndex].Cells[4].Value.ToString();
                    int phiPhong = int.Parse(money.Split('.')[0]);
                    this.txtPhiPhong.Text = String.Format("{0:0,0}", phiPhong);
                    

                }

                if (this.gVLichTrinh.Rows[e.RowIndex].Cells[5].Value is null)
                    this.txtMoTa.Text = String.Empty;
                else
                    this.txtMoTa.Text = this.gVLichTrinh.Rows[e.RowIndex].Cells[5].Value.ToString();

                // Ảnh
                if (this.gVLichTrinh.Rows[e.RowIndex].Cells[6].Value is null)
                    this.cbPic.Text = String.Empty;
                else
                     cbPic.Text = path+ this.gVLichTrinh.Rows[e.RowIndex].Cells[6].Value.ToString();
                //txt


            }
        }
      
        private void cbPic_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            this.picTour.Image = new Bitmap(this.cbPic.SelectedItem.ToString());
                this.picTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }

        private void button1_Click(object sender, EventArgs e)
        {
         
            txtMa.Text = "";
            txtPhiPhong.Text = "";
            txtTenDiaDanh.Text = "";
            txtTenKS.Text = "";
            cbPic.Text = "";
            cbTinh.Text = "";
            txtMoTa.Text = "";
   
        }
    
        

        private void btThem_Click(object sender, EventArgs e)
        {

            String ma = bus_lt.GetLast();
            if (ma != "0")
            {
                LichTrinhTour l = new LichTrinhTour();
                l.MaLichTrinh = ma;
                l.TenCacDiaDanh = txtTenDiaDanh.Text;
                l.Tinh = cbTinh.Text;
                l.KhachSan = txtTenKS.Text;
                l.MoTaLichTrinh = txtMoTa.Text;


                l.TienKS = decimal.Parse(txtPhiPhong.Text.Replace(",", ""));

                l.Picture = cbPic.Text.Substring(cbPic.Text.LastIndexOf("pic") + 4);
                l.NgayCapNhatGanNhat = DateTime.Now;
                if (bus_lt.ThemLichTrinh(l) == 1)
                {
                    MessageBox.Show("Thêm Thành Công");
                    bus_lt.List_LichTrinh(this.gVLichTrinh);
                }

                else
                    MessageBox.Show("Thêm Thất Bại");

            }
            else
                MessageBox.Show("Thêm Thất Bại");


        }

        private void btSua_Click(object sender, EventArgs e)
        {

            LichTrinhTour l = new LichTrinhTour();
            l.MaLichTrinh = txtMa.Text;
            l.TenCacDiaDanh = txtTenDiaDanh.Text;
            l.Tinh = cbTinh.Text;
            l.KhachSan = txtTenKS.Text;
            l.TienKS = decimal.Parse(txtPhiPhong.Text.Replace(",", ""));
            l.Picture = cbPic.Text.Substring(cbPic.Text.LastIndexOf("pic") + 4);
            l.NgayCapNhatGanNhat = DateTime.Now;
            l.MoTaLichTrinh = txtMoTa.Text;
            int a = bus_lt.SuaLichTrinh(l);
            if (a == 1)
            {
                MessageBox.Show("Sửa Thành Công");
                bus_lt.List_LichTrinh(this.gVLichTrinh);
            }
            else if (a == 0)
            {
                MessageBox.Show("Không tìm thấy mã Lịch Trình Tour: " + l.MaLichTrinh);

            }
            else
                MessageBox.Show("Sửa Thất Bại");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
            String ma = txtMa.Text;
            int a = bus_lt.XoaLichTrinh(ma);
            if (a == 1)
            {
                MessageBox.Show("Xóa Thành Công");
                bus_lt.List_LichTrinh(this.gVLichTrinh);
            }
            else if (a == 0)
            {
                MessageBox.Show("Không tìm thấy mã Lịch Trình Tour: " + ma);

            }
            else if(a == -1)
            {
                DialogResult r = MessageBox.Show("Lịch Trình Tour Này Đã Được Thêm Vào Tour Trước Đó Bạn Có Chắc Muốn Xóa Luôn Các Tour,Chi Tiết Đơn Hàng,...  Không?", "Xác Nhận", MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    if (bus_lt.XoaLichTrinhCoTrongTour(ma) == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        bus_lt.List_LichTrinh(this.gVLichTrinh);
                    }
                     
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }

                }
            }    
            else
                MessageBox.Show("Xóa Thất Bại");
        }

        
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.pnMoTa.Visible = true;
            lbNgay.Text = "Ngày" + this.ngay.ToString();

            //if (txtMoTa.Text != "")
            //{


            //    list_text = txtMoTa.Text.Split('^');
            //    if (ngay != this.list_text.Count() - 1)
            //    {
            //        this.btThemNgay.Text = "Xem Tiếp";
            //    }
            //    String[] list_text2 = list_text[0].Split('#');
            //    String[] moTa = list_text2[1].Split('@');
            //    String final = "";
            //    for (int k = 0; k < moTa.Length; k++)
            //    {
            //        final += moTa[k] + '\n';
            //    }

            //    for (int i = 0; i < list_text.Length; i++)
            //    {
            //        ThemMoTa(list_text[0], final);
            //    }

            //    this.rtbMain.Text = final;
            //    this.rtbHeading.Text = list_text2[0];
            //}
            // this.rtbMain.Text = txtMoTa.Text;

        }

        List<string> s = new List<string>();
        int ngay = 1;
        private void MoTa(int trangThai)
        {
            lbNgay.Text = "Ngày" + this.ngay.ToString();
            if (rtbHeading.Text != "" && rtbMain.Text != "")
                {
                     if(trangThai != 2)
                     {
                        String heading = rtbHeading.Text + "#";
                        String[] textMains = rtbMain.Text.Split('-');
                        String textMain = "";

                        for (int i = 0; i < textMains.Length; i++)
                        {
                            textMain += textMains[i];
                            if (i != textMains.Length - 1)
                                textMain += "@";
                        }
                    s.Add(heading + textMain + "^");
                     }    
                    
            }

                else
                {
                    if (rtbHeading.Text == "")
                    {
                        MessageBox.Show("Không thể để trống heading");
                    }
                    if (rtbMain.Text == "")
                    {
                        MessageBox.Show("Không thể để trống mô tả");
                   
                    }
                   return;
                }
               
            if (trangThai == 0)
            {
                ngay = 1;
                this.txtMoTa.Text = "";
                foreach (String str in s)
                {
                    this.txtMoTa.Text += str;
                }
                this.pnMoTa.Visible = false;
                this.rtbHeading.Text = "";
                this.rtbMain.Text = "";




            }
            else
            {
                this.rtbHeading.Text = "";
                this.rtbMain.Text = "";
                
                
               
                    ngay++;
                   lbNgay.Text = "Ngày" + this.ngay.ToString();


            }
                
        }
       
        private void btOk_Click(object sender, EventArgs e)
        {
            if (k == 0)
                MoTa(0);
            else
                XemMoTa(2);
        }

        private void btThemNgay_Click(object sender, EventArgs e)
        {
            if (k == 0)
                MoTa(1);
            else
                XemMoTa(1);

        }


        //private void ThemMoTa(String bheading, String bmain)
        //{
        //    String heading = bheading + "#";
        //    String[] textMains = bmain.Split('-');
        //    String textMain = "";

        //    for (int i = 0; i < textMains.Length; i++)
        //    {
        //        textMain += textMains[i];
        //        if (i != textMains.Length - 1)
        //            textMain += "@";

        //    }
        //    s.Add(heading + textMain + "^");
        //}
        //private void rtbMain_TextChanged(object sender, EventArgs e)
        //{
        //    String heading = rtbHeading.Text + "#";
        //    String[] textMains = rtbMain.Text.Split('-');
        //    String textMain = "";

        //    for (int i = 0; i < textMains.Length; i++)
        //    {
        //        textMain += textMains[i];
        //        if (i != textMains.Length - 1)
        //            textMain += "@";

        //    }
        //    s[this.ngay - 1] = ;
        //}

        private void rtbMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbMain.Text == "Nhập Nội Dung")
                rtbMain.Text = "";
        }

        private void rtbHeading_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbHeading.Text == "Nhập Tiêu Đề")
                rtbHeading.Text = "";
                
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            MoTa(2);
        }

        private void pnMoTa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }
        int k ;
        private void button2_Click(object sender, EventArgs e)
        {
            this.txtMoTa.Text = "";
            s.Clear();
            k = 0;
            this.pnMoTa.Visible = true;
            lbNgay.Text = "Ngày" + this.ngay.ToString();
        }
        String[] list_text;
        private void btXemMoTa_Click(object sender, EventArgs e)
        {
            if (txtMoTa.Text != String.Empty)
            {
                s.Clear();
                k = 1;
                this.pnMoTa.Visible = true;
                lbNgay.Text = "Ngày" + this.ngay.ToString();
                list_text = txtMoTa.Text.Split('^');
                //if (ngay != this.list_text.Count() - 1)
                //{
                //    this.btThemNgay.Text = "Xem Tiếp";
                //}
                String[] list_text2 = list_text[0].Split('#');
                String[] moTa = list_text2[1].Split('@');
                String final = "";
                for (int k = 0; k < moTa.Length; k++)
                {
                    final += moTa[k] + '\n';
                }


                this.rtbMain.Text = final;
                this.rtbHeading.Text = list_text2[0];
                ngay++;
            }
            else
                btXemMoTa.Enabled = true;
          

        }
        int j = 1;
        private void XemMoTa(int tt)
        {
            lbNgay.Text = "Ngày" + this.ngay.ToString();
            if (ngay < this.list_text.Count() -1)
            {
                this.btThemNgay.Text = "Xem Tiếp";
            }
            else
                this.btThemNgay.Enabled = false;

            
            if(tt == 1 )
            {
                String[] list_text2 = list_text[j].Split('#');
                String[] moTa = list_text2[1].Split('@');
                
                String final = "";
                for (int k = 0; k < moTa.Length; k++)
                {
                    final += moTa[k] + '\n';
                }
                this.rtbMain.Text = final;
                this.rtbHeading.Text = list_text2[0];
                j++;
            }    
            else
            {
                this.pnMoTa.Visible = false;
                this.rtbMain.Text = "";
                this.rtbHeading.Text = "";
                this.btThemNgay.Enabled = true;
                j = 1;
                ngay = 0;

            }
            ngay++;

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

       
 

