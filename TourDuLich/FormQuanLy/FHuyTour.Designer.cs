
namespace TourDuLich.FormQuanLy
{
    partial class FHuyTour
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
            this.gvHuy = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMaVe = new System.Windows.Forms.ComboBox();
            this.dtpNgayHuy = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHuy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvHuy)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTiltle
            // 
            this.labelTiltle.AutoSize = true;
            this.labelTiltle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiltle.ForeColor = System.Drawing.Color.White;
            this.labelTiltle.Location = new System.Drawing.Point(22, 25);
            this.labelTiltle.Name = "labelTiltle";
            this.labelTiltle.Size = new System.Drawing.Size(170, 35);
            this.labelTiltle.TabIndex = 2;
            this.labelTiltle.Text = "HỦY TOUR";
            // 
            // gvHuy
            // 
            this.gvHuy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(128)))));
            this.gvHuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHuy.GridColor = System.Drawing.Color.White;
            this.gvHuy.Location = new System.Drawing.Point(12, 72);
            this.gvHuy.Name = "gvHuy";
            this.gvHuy.RowHeadersWidth = 51;
            this.gvHuy.RowTemplate.Height = 24;
            this.gvHuy.Size = new System.Drawing.Size(1064, 487);
            this.gvHuy.TabIndex = 15;
            this.gvHuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHuy_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.cbMaVe);
            this.panel1.Controls.Add(this.dtpNgayHuy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaHuy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1098, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 534);
            this.panel1.TabIndex = 16;
            // 
            // cbMaVe
            // 
            this.cbMaVe.FormattingEnabled = true;
            this.cbMaVe.Location = new System.Drawing.Point(161, 193);
            this.cbMaVe.Name = "cbMaVe";
            this.cbMaVe.Size = new System.Drawing.Size(233, 27);
            this.cbMaVe.TabIndex = 27;
            // 
            // dtpNgayHuy
            // 
            this.dtpNgayHuy.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHuy.Enabled = false;
            this.dtpNgayHuy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHuy.Location = new System.Drawing.Point(161, 247);
            this.dtpNgayHuy.Name = "dtpNgayHuy";
            this.dtpNgayHuy.Size = new System.Drawing.Size(233, 27);
            this.dtpNgayHuy.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ngày Hủy: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // txtMaHuy
            // 
            this.txtMaHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHuy.Enabled = false;
            this.txtMaHuy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHuy.Location = new System.Drawing.Point(161, 140);
            this.txtMaHuy.Name = "txtMaHuy";
            this.txtMaHuy.Size = new System.Drawing.Size(233, 27);
            this.txtMaHuy.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã Vé: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã Hủy Tour: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Location = new System.Drawing.Point(596, 582);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(116, 48);
            this.btThoat.TabIndex = 23;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(470, 582);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(116, 48);
            this.btXoa.TabIndex = 25;
            this.btXoa.Text = "Xóa HT";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(337, 582);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(116, 48);
            this.btThem.TabIndex = 26;
            this.btThem.Text = "Thêm HT";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FHuyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1545, 663);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvHuy);
            this.Controls.Add(this.labelTiltle);
            this.Name = "FHuyTour";
            this.Text = "FHuyTour";
            this.Load += new System.EventHandler(this.FHuyTour_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvHuy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTiltle;
        private System.Windows.Forms.DataGridView gvHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbMaVe;
    }
}