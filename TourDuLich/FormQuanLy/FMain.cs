using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDuLich.FormQuanLy
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLichTrinh f = new FLichTrinh();
            f.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FTour f = new FTour();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FSoDatTour f = new FSoDatTour();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FChiTietDatVe f = new FChiTietDatVe();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FHuyTour f = new FHuyTour();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FNhanVien f = new FNhanVien();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FKhachHang f = new FKhachHang();
            f.ShowDialog();
        }
    }
}
