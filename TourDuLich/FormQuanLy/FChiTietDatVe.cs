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
    public partial class FChiTietDatVe : Form
    {
        public FChiTietDatVe()
        {
            InitializeComponent();
        }
        BUS_ChiTietDatVe bus_ct = new BUS_ChiTietDatVe();
        BUS_SoDatTour bus_s = new BUS_SoDatTour();
        int ma;
        public SoDatTour so;
        public String MaDH;
        public int TrangThai;
        public String maTour;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FChiTietDatVe_Load(object sender, EventArgs e)
        {
            ma = this.MaSoChiTiet();

            //this.GVCT.DataSource = ct;
            GVCT.ColumnCount = 3;

            GVCT.Columns[0].Name = "Ma Ve";
            GVCT.Columns[1].Name = "Ma Don";
            GVCT.Columns[2].Name = "Loai Ve";

            if (TrangThai == 0)
                SetGridView();

            SetColum();
            DinhDangF.setDataGridView(this.GVCT);
        }
        private void SetColum()
        {
            this.GVCT.Columns[0].Width = (int)(this.GVCT.Width * 0.3);
            this.GVCT.Columns[1].Width = (int)(this.GVCT.Width * 0.3);
            this.GVCT.Columns[2].Width = (int)(this.GVCT.Width * 0.3);

        }
        private void SetGridView()
        {
            List<ChiTietDatVe> v = bus_ct.List_CTDV(MaDH);
            for (int i = 0; i < v.Count; i++)
            {
                GVCT.Rows.Add(v[i].MaVe, v[i].MaDonHang, v[i].LoaiVe);
            }

        }
        private int MaSoChiTiet()
        {
            String ma = bus_ct.GetLastChiTiet();
            int m;
            if (ma == "0")
                m = 0;
            else
                m = int.Parse(ma);
            m++;
            return m;

        }
        List<ChiTietDatVe> list_ct = new List<ChiTietDatVe>();

        private void btThem_Click(object sender, EventArgs e)
        {
            String maDH;
            int LoaiVe;
            if (TrangThai == 1)
            {
                maDH = so.MaDon;
            }
            else
                maDH = MaDH;


            if (rdNL.Checked == true)
            {
                LoaiVe = 1;
            }
            else
            {
                LoaiVe = 0;
            }
            int sl = int.Parse(numSL.Value.ToString());

            for (int i = 0; i < sl; i++)
            {
                String maVe = "CT" + ma;
                GVCT.Rows.Add(maVe, maDH, LoaiVe);
                ChiTietDatVe c = new ChiTietDatVe();
                c.MaVe = maVe;
                c.MaDonHang = maDH;
                c.LoaiVe = LoaiVe;
                list_ct.Add(c);
                ma++;
            }



        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        List<String> List_maCTTT = new List<String>();
        private void btXoa_Click_1(object sender, EventArgs e)
        {

            String maCT = GVCT.CurrentRow.Cells[0].Value.ToString();
            if (bus_ct.ChiTietTonTai(maCT))
                List_maCTTT.Add(maCT);
            GVCT.Rows.RemoveAt(GVCT.CurrentCell.RowIndex);
            for (int i = 0; i < list_ct.Count; i++)
            {
                if (list_ct[i].MaVe == maCT)
                {
                    list_ct.Remove(list_ct[i]);
                    break;
                }
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = -1;

            if (list_ct != null || List_maCTTT != null)
            {
      
                if (TrangThai == 1)
                {
                    a = bus_s.Dat_Tour(so, list_ct);
                }
                else
                {
                    a = bus_ct.ThemListChiTiet(maTour, list_ct);
                    if(List_maCTTT != null)
                    {
                        if(bus_ct.KTChiTietDaHuyTour(List_maCTTT))
                        {
                            DialogResult r = MessageBox.Show("Tồn Tại Vé Đã Hủy Tour, Bạn Có Muốn Tiếp Tục Xóa Không? Điều Này Có Thể Không Thể Khôi Phục Lại Vé Được", "Xác Nhận", MessageBoxButtons.YesNo);
                            if(r == DialogResult.Yes)
                            {
                                bus_ct.XoaChiTietHuyTour(List_maCTTT);
                            }
                            else
                            {
                                return;
                            }
                        }   
                        else
                             bus_ct.XoaChiTiet(List_maCTTT);
                    }    
                   

                }

                if (a == 1)
                {
                    MessageBox.Show("Thành Công");
                    this.Close();
                }
                else if (a == -3)
                    MessageBox.Show("Không đủ số lượng Vé Cho Bạn");
                else
                    MessageBox.Show("Thất bại");

            }
        }

        private void GVCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.GVCT.Rows.Count)
            {

                //Mã Vé
                if (this.GVCT.Rows[e.RowIndex].Cells[0].Value is null)
                    this.txtMaVe.Text = String.Empty;
                else
                    txtMaVe.Text = this.GVCT.Rows[e.RowIndex].Cells[0].Value.ToString();


                //Mã Đơn
                if (this.GVCT.Rows[e.RowIndex].Cells[1].Value is null)
                    this.txtMaDonHang.Text = String.Empty;
                else
                    txtMaDonHang.Text = this.GVCT.Rows[e.RowIndex].Cells[1].Value.ToString();


                //Loại Vé
                if (this.GVCT.Rows[e.RowIndex].Cells[2].Value is null)
                {
                    rdNL.Checked = false;
                    rdTE.Checked = false;
                }

                else
                {
                    int k = int.Parse(this.GVCT.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if (k == 1)
                        rdNL.Checked = true;
                    else
                        rdTE.Checked = true;
                }

            }
        }
    }
}
