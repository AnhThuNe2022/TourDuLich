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
    public partial class FHuyTour : Form
    {
        public FHuyTour()
        {
            InitializeComponent();
        }
        BUS_HuyTour bus_ht = new BUS_HuyTour();
        private void FHuyTour_Load(object sender, EventArgs e)
        {


        }
        private void SetColum()
        {
            this.gvHuy.Columns[0].Width = (int)(this.gvHuy.Width * 0.15);
            this.gvHuy.Columns[1].Width = (int)(this.gvHuy.Width * 0.15);
            this.gvHuy.Columns[2].Width = (int)(this.gvHuy.Width * 0.75);

        }

        private void FHuyTour_Load_1(object sender, EventArgs e)
        {
            bus_ht.List_Huy(this.gvHuy);
            DinhDangF.setDataGridView(this.gvHuy);
            //bus_ht.List_MaVe(cbMaVe);
            SetColum();

        }

        private void gvHuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.gvHuy.Rows.Count)
            {

                //Mã
                if (this.gvHuy.Rows[e.RowIndex].Cells[0].Value is null)
                    this.txtMaHuy.Text = String.Empty;
                else
                    txtMaHuy.Text = this.gvHuy.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Mã Vé
                if (this.gvHuy.Rows[e.RowIndex].Cells[1].Value is null)
                    this.cbMaVe.Text = String.Empty;
                else
                    cbMaVe.Text = this.gvHuy.Rows[e.RowIndex].Cells[1].Value.ToString();

                //Ngày
                if (this.gvHuy.Rows[e.RowIndex].Cells[2].Value is null)
                    this.dtpNgayHuy.Text = String.Empty;
                else
                    dtpNgayHuy.Text = this.gvHuy.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HuyTour h = new HuyTour();
            h.MaHuyTour = MaSoDatTour();
            h.MaVe = cbMaVe.Text;
            h.NgayHuy = DateTime.Now;

            int a = bus_ht.Huy_Tour(h);
            if (a == 1)
            {
               
                MessageBox.Show("Hủy Vé " + cbMaVe.Text +" Thành Công");
                //bus_ht.HoanChoHuyVe(cbMaVe.Text);
                //bus_ht.KhoiPhucVe(h.MaVe);
                bus_ht.List_Huy(this.gvHuy);
               
            }
            else if (a == 0)
            {
                MessageBox.Show("Không Tìm Thấy Vé Cần Hủy");
            }
            else if (a == -2)
            {
                MessageBox.Show("Vé Này Đã Được Hủy Rồi");
            }
            else
            {
                MessageBox.Show("Hủy Vé Không Thành Công");
            }
                
                



        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int a = bus_ht.Xoa_HuyTour(txtMaHuy.Text);
            if (a == 1)
            {
                MessageBox.Show("Khôi Phục Vé " + cbMaVe.Text + " Thành Công");
                bus_ht.List_Huy(this.gvHuy);
            }
            else if (a == 0)
            {
                MessageBox.Show("Vé Chưa Bị Hủy Nên Không Thể Khôi Phục");
            }
            else
                MessageBox.Show("Khôi Phục Vé Không Thành Công");
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}