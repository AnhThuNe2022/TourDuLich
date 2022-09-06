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
    public partial class FKhachHang : Form
    {
        public FKhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            bus_kh.List_KH(this.gvKH);
            DinhDangF.setDataGridView(this.gvKH);
            SetColumn();
        }
        private void SetColumn()
        {
            this.gvKH.Columns[0].Width = (int)(this.gvKH.Width * 0.075);
            this.gvKH.Columns[1].Width = (int)(this.gvKH.Width * 0.2);
            this.gvKH.Columns[2].Width = (int)(this.gvKH.Width * 0.3);
            this.gvKH.Columns[3].Width = (int)(this.gvKH.Width * 0.075);
            this.gvKH.Columns[4].Width = (int)(this.gvKH.Width * 0.17);
            this.gvKH.Columns[5].Width = (int)(this.gvKH.Width * 0.17);

        }

      
        private void gvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.gvKH.Rows.Count)
            {

                //Mã
                if (this.gvKH.Rows[e.RowIndex].Cells[0].Value is null)
                    this.txtMaKH.Text = String.Empty;
                else
                    txtMaKH.Text = this.gvKH.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Tên KH
                if (this.gvKH.Rows[e.RowIndex].Cells[1].Value is null)
                    this.txtTenKH.Text = String.Empty;
                else
                    txtTenKH.Text = this.gvKH.Rows[e.RowIndex].Cells[1].Value.ToString();

                //Địa Chỉ

                if (this.gvKH.Rows[e.RowIndex].Cells[2].Value is null)
                    this.txtDiaChi.Text = String.Empty;
                else
                    txtDiaChi.Text = this.gvKH.Rows[e.RowIndex].Cells[2].Value.ToString();

                //Giới Tính

                if (this.gvKH.Rows[e.RowIndex].Cells[3].Value is null)
                {
                    this.rdbNam.Checked = false;
                    this.rdbNu.Checked = false;
                }

                else
                {
                    String s = this.gvKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (s == "False")
                    {
                        rdbNu.Checked = true;
                    }
                    else
                        rdbNam.Checked = true;

                }
         

                //Ngày Sinh
                if (this.gvKH.Rows[e.RowIndex].Cells[4].Value is null)
                    this.dtpNgaySinh.Text = String.Empty;
                else
                    dtpNgaySinh.Text = this.gvKH.Rows[e.RowIndex].Cells[4].Value.ToString();

                //SĐT

                if (this.gvKH.Rows[e.RowIndex].Cells[5].Value is null)
                    this.txtSDT.Text = String.Empty;
                else
                {
                    txtSDT.Text = this.gvKH.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(2);
                }    

                   

            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text != String.Empty)
            {
                if (txtSDT.Text[0] == '0')
                    txtSDT.Text = txtSDT.Text.Substring(1);
                if (txtSDT.Text.Length > 11)
                {
                    MessageBox.Show("Độ Dài Số Điện Thoại Không Hợp Lệ");
                    txtSDT.Text = "";
                }
            }
        }
     
        private void btThem_Click(object sender, EventArgs e)
        {

            KH k = new KH();
            k.TenKH = txtTenKH.Text;
            k.NgaySinh = dtpNgaySinh.Value;
            k.DiaChi = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            if (sdt != String.Empty)
                k.SĐT = decimal.Parse("84" + txtSDT.Text);
            if (rdbNam.Checked == true)
                k.GioiTinh = true;
            else
                k.GioiTinh = false;
            int a = bus_kh.ThemKH(k);
            if (a == 1)
            {
                MessageBox.Show("Thêm Thành Công!");
                bus_kh.List_KH(this.gvKH);

            }
            else if (a == 0)
                MessageBox.Show("Số Điện Thoại Bị Trùng Với Khách Hàng Khác");           
            else
                MessageBox.Show("Thêm Thất Bại");

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            KH k = new KH();
            k.MaKH = int.Parse(txtMaKH.Text);
            k.TenKH = txtTenKH.Text;
            k.NgaySinh = dtpNgaySinh.Value;
            k.DiaChi = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            if (sdt != String.Empty)
                k.SĐT = decimal.Parse("84" + txtSDT.Text);
            if (rdbNam.Checked == true)
                k.GioiTinh = true;
            else
                k.GioiTinh = false;
            int a = bus_kh.SuaKH(k);
            if (a == 1)
            {
                MessageBox.Show("Sửa Thành Công");
                bus_kh.List_KH(this.gvKH);

            }
            else if (a == 0)
                MessageBox.Show("Không tìm Thấy Mã Nhân Viên");
            else if (a == -1)
                MessageBox.Show("Số Điện Thoại Bị Trùng Với NV Khác");
            else
                MessageBox.Show("Sửa Thất Bại");


        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maKH = int.Parse(gvKH.CurrentRow.Cells[0].Value.ToString());
            int a = bus_kh.XoaKH(maKH);
            if (a == 1)
            {
                MessageBox.Show("Xóa Thành Công");
                bus_kh.List_KH(this.gvKH);

            }
            else if (a == -1)
            {
                DialogResult r = MessageBox.Show("Hiện Khách Hàng Đã Đặt Có Đơn Hàng Đặt Tour, Bạn Có Chắc Muốn Xóa Khách Hàng Này Không?", "Xác Nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (bus_kh.XoaKHTonTaiTrongSoDatTour(maKH) == 1)
                    {
                        MessageBox.Show("Xóa Thành CÔng");
                        bus_kh.List_KH(this.gvKH);

                    }

                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
            }
            else if (a == 0)
            {
                MessageBox.Show("Không tìm thấy mã nhân viên");
            }
            else
                MessageBox.Show("Xóa Thất bại");
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
