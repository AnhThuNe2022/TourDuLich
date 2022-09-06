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
namespace TourDuLich.FormQuanLy
{
    public partial class FSoDatTour : Form
    {
        public FSoDatTour()
        {
            InitializeComponent();
        }
        BUS_SoDatTour bus_dt = new BUS_SoDatTour();
        private void FSoDatTour_Load(object sender, EventArgs e)
        {
           
            DinhDangF.setDataGridView(this.gVSDT);
           
            bus_dt.cbTour(this.cbMaTour);
        }
        
        private void SetColum()
        {
            this.gVSDT.Columns[0].Width = (int)(this.gVSDT.Width * 0.12);
            this.gVSDT.Columns[1].Width = (int)(this.gVSDT.Width * 0.12);
            this.gVSDT.Columns[2].Width = (int)(this.gVSDT.Width * 0.12);
            this.gVSDT.Columns[3].Width = (int)(this.gVSDT.Width * 0.12);
            this.gVSDT.Columns[4].Width = (int)(this.gVSDT.Width * 0.26);
            this.gVSDT.Columns[5].Width = (int)(this.gVSDT.Width * 0.26);
           
        }
        //p.MaDon,
        //        p.MaKH,
        //        p.MaTour,
        //        p.SoPhong,
        //        p.NgayDat,
        //        p.TongTien
        private void gVSDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.gVSDT.Rows.Count)
            {

                //Mã Đơn
                if (this.gVSDT.Rows[e.RowIndex].Cells[0].Value is null)
                    this.txtMaDon.Text = String.Empty;
                else
                    txtMaDon.Text = this.gVSDT.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Mã KH
                if (this.gVSDT.Rows[e.RowIndex].Cells[1].Value is null)
                    this.txtMaKH.Text = String.Empty;
                else
                    txtMaKH.Text = this.gVSDT.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Mã Tour
                if (this.gVSDT.Rows[e.RowIndex].Cells[2].Value is null)
                    this.cbMaTour.Text = String.Empty;
                else
                    cbMaTour.Text = this.gVSDT.Rows[e.RowIndex].Cells[2].Value.ToString();

                //Số Phòng
                if (this.gVSDT.Rows[e.RowIndex].Cells[3].Value is null)
                    this.numSoPhong.Text = String.Empty;
                else
                    numSoPhong.Text = this.gVSDT.Rows[e.RowIndex].Cells[3].Value.ToString();

                //Ngày Đặt
                if (this.gVSDT.Rows[e.RowIndex].Cells[4].Value is null)
                    this.dtpNgayDat.Text = String.Empty;
                else
                    dtpNgayDat.Text = this.gVSDT.Rows[e.RowIndex].Cells[4].Value.ToString();


                //Tổng Tiền
                if (this.gVSDT.Rows[e.RowIndex].Cells[5].Value is null)
                    this.txtTongTien.Text = String.Empty;
                else
                {
                    String s = this.gVSDT.Rows[e.RowIndex].Cells[5].Value.ToString();
                    int gia = int.Parse(s.Split('.')[0]);
                    txtTongTien.Text = String.Format("{0:0,0 }", gia);
                }    
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if(txtMaKH.Text == string.Empty)
            {
                MessageBox.Show("Dữ Liệu Thiếu");
                return;
            }  
            else
            {
                if(!bus_dt.KTKhachHang(int.Parse(txtMaKH.Text)))
                {
                    MessageBox.Show("Không Tồn Tại Mã Khách Hàng");
                    return;
                }    



            }    
            SoDatTour s = new SoDatTour();

            s.MaDon = MaSoDatTour();
            s.MaKH = int.Parse(txtMaKH.Text);
            s.MaTour = cbMaTour.Text;
            MessageBox.Show(s.MaTour);
            s.SoPhong = int.Parse(numSoPhong.Value.ToString());
            s.NgayDat = DateTime.Now;

                
            FChiTietDatVe f = new FChiTietDatVe();
            f.so = s;
            f.TrangThai = 1;
            f.ShowDialog();

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

        private void FSoDatTour_Activated(object sender, EventArgs e)
        {
            bus_dt.List_SoDatTour(this.gVSDT);
            SetColum();
        }

        private void gVSDT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FChiTietDatVe f = new FChiTietDatVe();
            f.MaDH = gVSDT.CurrentRow.Cells[0].Value.ToString();
            f.maTour = cbMaTour.Text;
            f.TrangThai = 0;
            f.ShowDialog();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            String maDonHang = gVSDT.CurrentRow.Cells[0].Value.ToString();
            int a = bus_dt.XoaDonHang(maDonHang);

            if (a == 1)
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else if (a == -1)
            {
                DialogResult r =  MessageBox.Show("Đơn Hàng Này Đã Có Các Mã Chi Tiết Bạn Có Muốn Tiếp Tục Xóa Đơn Hàng Này Hay Không ", "Xác Nhận", MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    int k = bus_dt.XoaDonHangCoChiTiet(maDonHang);
                    if (k == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else
                        MessageBox.Show("Xóa Thất Bại 2");

                }   
                

                

            }
            else if(a == -2)  
                MessageBox.Show("Xóa Thất Bại");
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Đơn Hàng Cần Sửa");
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SoDatTour s = new SoDatTour();

            s.MaDon = txtMaDon.Text;
            s.MaKH = int.Parse(txtMaKH.Text);
            s.MaTour = cbMaTour.Text;
            s.SoPhong = int.Parse(numSoPhong.Value.ToString());
            s.NgayDat = dtpNgayDat.Value;

            int a = bus_dt.SuaDH(s);
            if (a == 1)
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else if (a == 0)
            {
                MessageBox.Show("Không Tìm Thấy Mã Đơn Hàng Cần Sửa");
            }
            else
                MessageBox.Show("Sửa Thất Bại");
                



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
