
namespace TourDuLich.FormQuanLy
{
    partial class FChiTietDatVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTiltle = new System.Windows.Forms.Label();
            this.GVCT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rdTE = new System.Windows.Forms.RadioButton();
            this.rdNL = new System.Windows.Forms.RadioButton();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVCT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTiltle
            // 
            this.labelTiltle.AutoSize = true;
            this.labelTiltle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiltle.ForeColor = System.Drawing.Color.White;
            this.labelTiltle.Location = new System.Drawing.Point(27, 26);
            this.labelTiltle.Name = "labelTiltle";
            this.labelTiltle.Size = new System.Drawing.Size(264, 35);
            this.labelTiltle.TabIndex = 1;
            this.labelTiltle.Text = "CHI TIẾT ĐẶT VÉ ";
            // 
            // GVCT
            // 
            this.GVCT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(128)))));
            this.GVCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCT.GridColor = System.Drawing.Color.White;
            this.GVCT.Location = new System.Drawing.Point(12, 71);
            this.GVCT.Name = "GVCT";
            this.GVCT.RowHeadersWidth = 51;
            this.GVCT.RowTemplate.Height = 24;
            this.GVCT.Size = new System.Drawing.Size(1085, 528);
            this.GVCT.TabIndex = 14;
            this.GVCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCT_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.txtMaDonHang);
            this.panel1.Controls.Add(this.numSL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdTE);
            this.panel1.Controls.Add(this.rdNL);
            this.panel1.Controls.Add(this.txtMaVe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1103, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 578);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDonHang.Enabled = false;
            this.txtMaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonHang.Location = new System.Drawing.Point(163, 210);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(233, 26);
            this.txtMaDonHang.TabIndex = 32;
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(163, 325);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(120, 22);
            this.numSL.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Số Lượng: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // rdTE
            // 
            this.rdTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdTE.AutoSize = true;
            this.rdTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTE.ForeColor = System.Drawing.Color.White;
            this.rdTE.Location = new System.Drawing.Point(299, 275);
            this.rdTE.Name = "rdTE";
            this.rdTE.Size = new System.Drawing.Size(85, 24);
            this.rdTE.TabIndex = 28;
            this.rdTE.Text = "Trẻ Em";
            this.rdTE.UseVisualStyleBackColor = true;
            // 
            // rdNL
            // 
            this.rdNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdNL.AutoSize = true;
            this.rdNL.Checked = true;
            this.rdNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNL.ForeColor = System.Drawing.Color.White;
            this.rdNL.Location = new System.Drawing.Point(163, 275);
            this.rdNL.Name = "rdNL";
            this.rdNL.Size = new System.Drawing.Size(106, 24);
            this.rdNL.TabIndex = 29;
            this.rdNL.TabStop = true;
            this.rdNL.Text = "Người Lớn";
            this.rdNL.UseVisualStyleBackColor = true;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaVe.Enabled = false;
            this.txtMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVe.Location = new System.Drawing.Point(163, 143);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(233, 26);
            this.txtMaVe.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã Vé: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã Đơn Hàng: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Loại Vé: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(296, 623);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(116, 48);
            this.btThem.TabIndex = 22;
            this.btThem.Text = "Thêm CTV";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(540, 623);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 48);
            this.button3.TabIndex = 22;
            this.button3.Text = "Xác Nhận";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(418, 623);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(116, 48);
            this.btXoa.TabIndex = 23;
            this.btXoa.Text = "Xóa CTV";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // FChiTietDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1545, 683);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GVCT);
            this.Controls.Add(this.labelTiltle);
            this.Name = "FChiTietDatVe";
            this.Text = "FChiTietDatVe";
            this.Load += new System.EventHandler(this.FChiTietDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVCT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTiltle;
        private System.Windows.Forms.DataGridView GVCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdTE;
        private System.Windows.Forms.RadioButton rdNL;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Button btXoa;
    }
}