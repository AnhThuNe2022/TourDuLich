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
    public partial class FTour : Form
    {
        public FTour()
        {
            InitializeComponent();
        }
        BUS_Tour bus_t = new BUS_Tour();
        private void FTour_Load(object sender, EventArgs e)
        {
            this.gvTour.DataSource = bus_t.List_Tour2();
            DinhDangF.setDataGridView(this.gvTour);
            SetColum();
            bus_t.List_NguoiDieuHanh(CbNguoiDieuHanh);
            bus_t.List_LichTrinhTour(cbMaLichTrinh);

        }

        private void SetColum()
        {
            this.gvTour.Columns[0].Width = (int)(this.gvTour.Width * 0.05);
            this.gvTour.Columns[1].Width = (int)(this.gvTour.Width * 0.075);
            this.gvTour.Columns[2].Width = (int)(this.gvTour.Width * 0.15);
            this.gvTour.Columns[3].Width = (int)(this.gvTour.Width * 0.15);
            this.gvTour.Columns[4].Width = (int)(this.gvTour.Width * 0.15);
            this.gvTour.Columns[5].Width = (int)(this.gvTour.Width * 0.075);
            this.gvTour.Columns[6].Width = (int)(this.gvTour.Width * 0.1);
            this.gvTour.Columns[7].Width = (int)(this.gvTour.Width * 0.1);
            this.gvTour.Columns[8].Width = (int)(this.gvTour.Width * 0.05);
            this.gvTour.Columns[9].Width = (int)(this.gvTour.Width * 0.05);
            this.gvTour.Columns[10].Width = (int)(this.gvTour.Width * 0.05);
        }

        private void gvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.gvTour.Rows.Count)
            {

                //Mã Tour
                if (this.gvTour.Rows[e.RowIndex].Cells[0].Value is null)
                    this.txtMaTour.Text = String.Empty;
                else
                    txtMaTour.Text = this.gvTour.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Mã Lịch Trình
                if (this.gvTour.Rows[e.RowIndex].Cells[1].Value is null)
                    this.cbMaLichTrinh.Text = String.Empty;
                else
                    cbMaLichTrinh.Text = this.gvTour.Rows[e.RowIndex].Cells[1].Value.ToString();

                //Điểm Khởi Hành

                if (this.gvTour.Rows[e.RowIndex].Cells[4].Value is null)
                    this.cbKH.Text = String.Empty;
                else
                    cbKH.Text = this.gvTour.Rows[e.RowIndex].Cells[4].Value.ToString();

                //Người Điều Hành

                if (this.gvTour.Rows[e.RowIndex].Cells[5].Value is null)
                    this.CbNguoiDieuHanh.Text = String.Empty;
                else
                    CbNguoiDieuHanh.Text = this.gvTour.Rows[e.RowIndex].Cells[5].Value.ToString();

                //Ngày Khởi Hành

                if (this.gvTour.Rows[e.RowIndex].Cells[2].Value is null)
                    this.dtpNgayKH.Text = String.Empty;
                else
                    dtpNgayKH.Text = this.gvTour.Rows[e.RowIndex].Cells[2].Value.ToString();

                //Ngày Về

                if (this.gvTour.Rows[e.RowIndex].Cells[3].Value is null)
                    this.dtpNgayVe.Text = String.Empty;
                else
                    dtpNgayVe.Text = this.gvTour.Rows[e.RowIndex].Cells[3].Value.ToString();

                //Giá Vé Trẻ Em
                
                if (this.gvTour.Rows[e.RowIndex].Cells[6].Value is null)
                    this.txtGiaVeTreEm.Text = String.Empty;
                else
                {
                    String s = this.gvTour.Rows[e.RowIndex].Cells[6].Value.ToString();
                    int giaTE = int.Parse(s.Split('.')[0]);
                    this.txtGiaVeTreEm.Text = String.Format("{0:0,0 }", giaTE);
                  
                }    
                    

                //Giá Vé Người Lớn

                if (this.gvTour.Rows[e.RowIndex].Cells[7].Value is null)
                    this.txtGiaVeNguoiLon.Text = String.Empty;
                else
                {
                    String s = this.gvTour.Rows[e.RowIndex].Cells[7].Value.ToString();
                    int giaNL = int.Parse(s.Split('.')[0]);
                    txtGiaVeNguoiLon.Text = String.Format("{0:0,0}", giaNL);
                }    
                   


                //Tổng Số Lượng Vé

                if (this.gvTour.Rows[e.RowIndex].Cells[8].Value is null)
                    this.numTongSLVe.Text = String.Empty;
                else
                    numTongSLVe.Text = this.gvTour.Rows[e.RowIndex].Cells[8].Value.ToString();

                //Tình Trạng
                if (this.gvTour.Rows[e.RowIndex].Cells[10].Value is null)
                    this.cbTinhTrang.Text = String.Empty;
                else
                {
                    int k = int.Parse( this.gvTour.Rows[e.RowIndex].Cells[10].Value.ToString());
                    if (k == 1)
                        cbTinhTrang.Text = "Tour Đang Thực Hiện";
                    else
                        cbTinhTrang.Text = "Tour Đã Xong";


                }


            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (dtpNgayKH.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày Khởi Hành Không Thể Là Quá Khứ");
            }
            else 
            {
                if (this.KTNgay())
                {

                    Tour t = new Tour();
                    t.MaTour = bus_t.GetMaTour();
                    t.MaLichTrinh = cbMaLichTrinh.Text;
                    t.NgayKhoiHanh = dtpNgayKH.Value;
                    t.NgayVe = dtpNgayVe.Value;
                    t.NguoiDieuHanh = CbNguoiDieuHanh.Text;
                    t.GiaVeNguoiLon = decimal.Parse(txtGiaVeNguoiLon.Text.Replace(",", ""));
                    t.GiaVeTreEm = decimal.Parse(txtGiaVeTreEm.Text.Replace(",", ""));
                    t.SoLuongVe = int.Parse(numTongSLVe.Value.ToString());
                    t.DiemKhoiHanh = cbKH.Text;
                    t.SoLuongDaDat = 0;

                    if (bus_t.ThemTour(t) == 1)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        this.gvTour.DataSource = bus_t.List_Tour2();
                    }
                    else
                        MessageBox.Show("Thêm Thất Bại");

                }
                else
                {
                    MessageBox.Show("Ngày Khởi Hành Và Ngày Về Không Hợp Lệ");
                }

            }
            



        }

        private bool KTNgay()
        {
            if(this.dtpNgayKH.Value > this.dtpNgayVe.Value)
            {
                return false;
            }
            return true;
        }

        private void txtGiaVeTreEm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (this.KTNgay())
            {
                Tour t = new Tour();
                t.MaTour = txtMaTour.Text;
                t.MaLichTrinh = cbMaLichTrinh.Text;
                t.NgayKhoiHanh = dtpNgayKH.Value;
                t.NgayVe = dtpNgayVe.Value;
                t.NguoiDieuHanh = CbNguoiDieuHanh.Text;
                t.GiaVeNguoiLon = decimal.Parse(txtGiaVeNguoiLon.Text.Replace(",", ""));
                t.GiaVeTreEm = decimal.Parse(txtGiaVeTreEm.Text.Replace(",", ""));
                t.SoLuongVe = int.Parse(numTongSLVe.Value.ToString());
                t.DiemKhoiHanh = cbKH.Text;

                int a = bus_t.SuaTour(t);
                if (a == 1)
                {
                    MessageBox.Show("Sửa Thành Công");
                    this.gvTour.DataSource = bus_t.List_Tour2();

                }
                else if (a == 0)
                {
                    MessageBox.Show("Không Tìm Thấy Mã Tour" + t.MaTour);
                }
                else
                    MessageBox.Show("Sửa Không Thành Công"); 
            }
            else
            {
                MessageBox.Show("Ngày Khởi Hành Và Ngày Về Không Hợp Lệ");
            }    
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            String maTour = gvTour.CurrentRow.Cells[0].Value.ToString();
            int a = bus_t.XoaTour(maTour);

            if (a == 1)
            {
                MessageBox.Show("Xóa Thành Công");
                this.gvTour.DataSource = bus_t.List_Tour2();
            }
            else if (a == -1)
            {
                DialogResult r = MessageBox.Show("Tour Này Đã Có Các Đơn Hàng Bạn Có Muốn Tiếp Tục Xóa Tour Này Hay Không ", "Xác Nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    int k = bus_t.XoaTourCoDonHang(maTour);
                    if (k == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        this.gvTour.DataSource = bus_t.List_Tour2();

                    }
                    else
                        MessageBox.Show("Xóa Thất Bại ");

                }
            }
            else if(a == -2)  
                MessageBox.Show("Xóa Thất Bại");
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Tour Cần Sửa");
            }

}

        private void dtpNgayKH_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaVeTreEm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtGiaVeNguoiLon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
