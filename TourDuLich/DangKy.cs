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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
           
           
        }
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        
        private void txtHo_Click(object sender, EventArgs e)
        {
            if (txtHo.Text == "Họ")
                txtHo.Text = "";
        }

        private void txtTen_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "Tên")
                txtTen.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
                txtEmail.Text = "";

        }

        private void txtSDT_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Số Điện Thoại")
                txtSDT.Text = "";

        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa Chỉ")
                txtDiaChi.Text = "";
        }

        private void txtCMT_Click(object sender, EventArgs e)
        {
            if (txtCMT.Text == "Chứng Minh Thư")
                txtCMT.Text = "";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật Khẩu")
                txtMatKhau.Text = "";
            txtMatKhau.PasswordChar = '*';
            
        }

        private void txtXacNhan_Click(object sender, EventArgs e)
        {
            if (txtXacNhan.Text == "Xác Nhận Mật Khẩu")
                txtXacNhan.Text = "";
            txtXacNhan.PasswordChar = '*';
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if(txtHo.Text == String.Empty || txtTen.Text == String.Empty || txtSDT.Text == String.Empty || txtCMT.Text == String.Empty)
            {
                MessageBox.Show("Không Thể Để Trống");
            }    
            else
            {
                if(txtMatKhau.Text == String.Empty || txtXacNhan.Text ==String.Empty)
                {
                    MessageBox.Show("Không Thể Để Trống Mật Khẩu");
                }
                else
                {
                    if (txtSDT.Text.Length <= 11)
                    {

                        if (txtMatKhau.Text == txtXacNhan.Text)
                        {
                            KH k = new KH();
                            k.TenKH = txtHo.Text + " " + txtTen.Text;
                            k.NgaySinh = dtpNgaySinh.Value;
                            k.DiaChi = txtDiaChi.Text;
                            k.Email = txtEmail.Text;
                            if(txtCMT.Text  != String.Empty )
                                k.ChungMinhThu = decimal.Parse(txtCMT.Text);
                            k.MatKhau = txtMatKhau.Text;
                            String sdt = txtSDT.Text;
                            if (sdt[0] == '0')
                                k.SĐT = decimal.Parse("84" + sdt.Substring(2));
                            else
                            {
                                MessageBox.Show("Số Điện Thoại Không Hợp lệ");
                                return;
                            }




                            if (rdNam.Checked == true)
                                k.GioiTinh = true;
                            else
                                k.GioiTinh = false;
                            int a = bus_kh.ThemKH(k);
                            if (a == 1)
                            {
                                MessageBox.Show("Đăng Ký Thành Công!");

                            }
                            else if (a == 0)
                                MessageBox.Show("Số Điện Thoại Bị Trùng Với Khách Hàng Khác");
                            else
                                MessageBox.Show("Thêm Thất Bại");




                        }
                        else
                            MessageBox.Show("Mật Khẩu Xác Nhận Với Mật Khẩu Trên Không Giống Nhau");
                    }
                    else
                        MessageBox.Show("Số Điện Thoại Không Hợp Lệ");
                }
            }    
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
