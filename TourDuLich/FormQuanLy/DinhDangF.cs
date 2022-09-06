using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDuLich.FormQuanLy
{
    class DinhDangF
    {

        public static void setDataGridView( DataGridView gv)
        {
            gv.DefaultCellStyle.Font = new Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gv.DefaultCellStyle.ForeColor = Color.White;
            gv.DefaultCellStyle.BackColor = gv.BackgroundColor;
            gv.EnableHeadersVisualStyles = false;
            gv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //gVLichTrinh.Height = gVLichTrinh.Rows.GetRowsHeight(DataGridViewElementStates.None) + gVLichTrinh.ColumnHeadersHeight + 2;

            //gVLichTrinh.Width = gVLichTrinh.Columns.GetColumnsWidth(DataGridViewElementStates.None) + gVLichTrinh.RowHeadersWidth + 2;


           
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gv.ColumnHeadersHeight = 40;

            gv.RowTemplate.Resizable = DataGridViewTriState.True;
            gv.RowTemplate.Height = 100;
            gv.RowHeadersVisible = false;
            gv.ReadOnly = true;
        }
    }
}
