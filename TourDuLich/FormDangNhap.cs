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
using TourDuLich.FormQuanLy;
namespace TourDuLich
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            if (cbKHQL.Text == "Khách Hàng")
            {

                if (txtSĐT.Text != String.Empty && txtMatKhau.Text != String.Empty)
                {
                    string soDau = this.txtSĐT.Text.Substring(0, 1);
                    if (this.txtSĐT.Text.Substring(0, 1) == "0" || this.txtSĐT.Text.Substring(0, 2) == "84")
                    {
                        decimal sdt = decimal.Parse(txtSĐT.Text);
                        if (this.txtSĐT.Text.Substring(0, 1) == "0")
                            sdt = decimal.Parse(String.Format("84{0}", this.txtSĐT.Text.Substring(1).ToString()));
                        String mk = this.txtMatKhau.Text;
                        KH K_H = new KH();
                        if (bus_kh.GetKH(sdt, mk, ref K_H) == 1)
                        {
                            MessageBox.Show("Đăng Nhập Thành Công");
                            FChonTour f = new FChonTour();
                            f.khachHang = K_H;
                            f.ShowDialog();
                            //this.Close();
                        }
                        else
                            MessageBox.Show("Số Điện Thoại Hoặc Mật Khẩu sai");
                    }
                    else

                        MessageBox.Show("Số điện thoại không hợp lệ");
                }
                else
                {
                    MessageBox.Show("Hãy Nhập SDT Và Mật Khẩu Đầy Đủ");
                }     
            }
            else
            {
                if (txtSĐT.Text != String.Empty && txtMatKhau.Text != String.Empty)
                {
                    string soDau = this.txtSĐT.Text.Substring(0, 1);
                    if (this.txtSĐT.Text.Substring(0, 1) == "0" || this.txtSĐT.Text.Substring(0, 2) == "84")
                    {
                        decimal sdt = decimal.Parse(txtSĐT.Text);
                        if (this.txtSĐT.Text.Substring(0, 1) == "0")
                            sdt = decimal.Parse(String.Format("84{0}", this.txtSĐT.Text.Substring(1).ToString()));
                        String mk = this.txtMatKhau.Text;
                        NhanVien nv = new NhanVien();
                        if (bus_nv.GetNV(sdt, mk, ref nv) == 1)
                        {
                            MessageBox.Show("Đăng Nhập Thành Công");
                            FMain f = new FMain();
                            f.ShowDialog();
                            //this.Close();
                        }
                        else
                            MessageBox.Show("Số Điện Thoại Hoặc Mật Khẩu sai");
                    }
                    else

                        MessageBox.Show("Số điện thoại không hợp lệ");
                }
                else
                {
                    MessageBox.Show("Hãy Nhập SDT Và Mật Khẩu Đầy Đủ");
                }


            }    
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSĐT_Click(object sender, EventArgs e)
        {
            if(txtSĐT.Text == "Số Điện Thoại")
                this.txtSĐT.Text = "";
        }

        private void txtSĐT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
                txtSĐT.Text = "Số Điện Thoại";

        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật Khẩu")
                this.txtMatKhau.Text = "";
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
                this.txtMatKhau.Text = "Mật Khẩu";
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy f = new DangKy();
            f.Show();

        }
    }
}
