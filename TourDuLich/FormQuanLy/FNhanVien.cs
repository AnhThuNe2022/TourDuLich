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
    public partial class FNhanVien : Form
    {
        public FNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        private void FNhanVien_Load(object sender, EventArgs e)
        {
            bus_nv.show(this.gvNV);
            DinhDangF.setDataGridView(this.gvNV);
            SetColum();
        }



        private void SetColum()
        {
            this.gvNV.Columns[0].Width = (int)(this.gvNV.Width * 0.075);
            this.gvNV.Columns[1].Width = (int)(this.gvNV.Width * 0.15);
            this.gvNV.Columns[2].Width = (int)(this.gvNV.Width * 0.15);
            this.gvNV.Columns[3].Width = (int)(this.gvNV.Width * 0.05);
            this.gvNV.Columns[4].Width = (int)(this.gvNV.Width * 0.3);
            this.gvNV.Columns[5].Width = (int)(this.gvNV.Width * 0.15);
            this.gvNV.Columns[6].Width = (int)(this.gvNV.Width * 0.15);
        }

  
        private void gvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.gvNV.Rows.Count)
            {

                //Mã
                if (this.gvNV.Rows[e.RowIndex].Cells[0].Value is null)
                    this.txtMaNV.Text = String.Empty;
                else
                    txtMaNV.Text = this.gvNV.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Tên NV
                if (this.gvNV.Rows[e.RowIndex].Cells[1].Value is null)
                    this.txtTenNV.Text = String.Empty;
                else
                    txtTenNV.Text = this.gvNV.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Ngày Sinh    
                if (this.gvNV.Rows[e.RowIndex].Cells[2].Value is null)
                    this.dtpNgaySinh.Text = String.Empty;
                else
                    dtpNgaySinh.Text = this.gvNV.Rows[e.RowIndex].Cells[2].Value.ToString();

                //Giới Tính
                if (this.gvNV.Rows[e.RowIndex].Cells[3].Value is null)
                {
                    this.rdNam.Checked = false;
                    this.rdNu.Checked = false;
                }    
                                   
                else
                {
                   String s = this.gvNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (s == "0")
                    {
                        rdNu.Checked = true;
                    }
                    else
                        rdNam.Checked = true;

                }    
                   

                //Địa CHỉ

                if (this.gvNV.Rows[e.RowIndex].Cells[4].Value is null)
                    this.txtDiaChi.Text = String.Empty;
                else
                    txtDiaChi.Text = this.gvNV.Rows[e.RowIndex].Cells[4].Value.ToString();

                //Chức Vụ
                if (this.gvNV.Rows[e.RowIndex].Cells[5].Value is null)
                    this.txtChucVu.Text = String.Empty;
                else
                    txtChucVu.Text = this.gvNV.Rows[e.RowIndex].Cells[5].Value.ToString();

                //SĐT
                if (this.gvNV.Rows[e.RowIndex].Cells[6].Value is null)
                    this.txtSoDT.Text = String.Empty;
                else
                {
                    txtSoDT.Text = this.gvNV.Rows[e.RowIndex].Cells[6].Value.ToString().Substring(2);
                }


            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            NhanVien s = new NhanVien();
            s.MaNhanVien = bus_nv.GetLastMaNV();
            s.TenNhanVien = txtTenNV.Text;
            s.NgaySinh =dtpNgaySinh.Value;
            String sdt = txtSoDT.Text;
            if(sdt != String.Empty)
                s.SĐT =  decimal.Parse("84" + txtSoDT.Text);
            s.DiaChi = txtDiaChi.Text;
            s.ChucVu = txtChucVu.Text;

            if (rdNam.Checked == true)
                s.GioiTinh = 1;
            else
                s.GioiTinh = 0;

            int a = bus_nv.themNV(s);
            if ( a == 1)
            {
                MessageBox.Show("Thêm Thành Công!");
                bus_nv.show(this.gvNV);
            }
            else if( a == 0)
                MessageBox.Show("Thêm Thất Bại");
            else
                MessageBox.Show("Số Điện Thoại Bị Trùng Với NV Khác");
        }

        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            if(txtSoDT.Text  != String.Empty)
            {
                if (txtSoDT.Text[0] == '0')
                    txtSoDT.Text = txtSoDT.Text.Substring(1);
                if(txtSoDT.Text.Length > 11)
                {
                    MessageBox.Show("Độ Dài Số Điện Thoại Không Hợp Lệ");
                    txtSoDT.Text = "";
                }    
            }
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NhanVien s = new NhanVien();
            s.MaNhanVien = txtMaNV.Text;
            s.TenNhanVien = txtTenNV.Text;
            s.NgaySinh = dtpNgaySinh.Value;
            s.SĐT = decimal.Parse("84" + txtSoDT.Text);
            s.DiaChi = txtDiaChi.Text;
            s.ChucVu = txtChucVu.Text;
            if (rdNam.Checked == true)
                s.GioiTinh = 1;
            else
                s.GioiTinh = 0;
            int a = bus_nv.SuaNV(s);

            if (a == 1)
            {
                MessageBox.Show("Sửa Thành Công");
                bus_nv.show(this.gvNV);
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

            if (txtChucVu.Text != "Quản Lý")
            {

                int a = bus_nv.XoaNV(txtMaNV.Text, txtChucVu.Text);
                if (a == 1)
                {
                    MessageBox.Show("Xóa Thành Công");
                    bus_nv.show(this.gvNV);
                }
                else if (a == -1)
                {
                    DialogResult r = MessageBox.Show("Hiện Nhân Viên Này Đã Được Phân Công Điều Hành Trong Tour, Bạn Có Muốn Xóa NV Này Không?", "Xác Nhận", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        if (bus_nv.XoaNhanVienTonTaiTrongTour(txtMaNV.Text) == 1)
                        {
                            MessageBox.Show("Xóa Thành CÔng");
                            bus_nv.show(this.gvNV);
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
            else
                MessageBox.Show("Không Thể Xóa Quản Lý");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
