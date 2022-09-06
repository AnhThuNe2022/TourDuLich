
namespace TourDuLich.FormQuanLy
{
    partial class FTour
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTiltle = new System.Windows.Forms.Label();
            this.gvTour = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMaLichTrinh = new System.Windows.Forms.ComboBox();
            this.numTongSLVe = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayKH = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.CbNguoiDieuHanh = new System.Windows.Forms.ComboBox();
            this.txtGiaVeNguoiLon = new System.Windows.Forms.TextBox();
            this.txtGiaVeTreEm = new System.Windows.Forms.TextBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvTour)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongSLVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, -53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // labelTiltle
            // 
            this.labelTiltle.AutoSize = true;
            this.labelTiltle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiltle.ForeColor = System.Drawing.Color.White;
            this.labelTiltle.Location = new System.Drawing.Point(53, 26);
            this.labelTiltle.Name = "labelTiltle";
            this.labelTiltle.Size = new System.Drawing.Size(237, 35);
            this.labelTiltle.TabIndex = 0;
            this.labelTiltle.Text = "TOUR DU LỊCH ";
            // 
            // gvTour
            // 
            this.gvTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(127)))));
            this.gvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTour.Location = new System.Drawing.Point(50, 79);
            this.gvTour.Name = "gvTour";
            this.gvTour.RowHeadersWidth = 51;
            this.gvTour.RowTemplate.Height = 24;
            this.gvTour.Size = new System.Drawing.Size(867, 505);
            this.gvTour.TabIndex = 16;
            this.gvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTour_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.cbMaLichTrinh);
            this.panel1.Controls.Add(this.numTongSLVe);
            this.panel1.Controls.Add(this.dtpNgayKH);
            this.panel1.Controls.Add(this.dtpNgayVe);
            this.panel1.Controls.Add(this.cbKH);
            this.panel1.Controls.Add(this.cbTinhTrang);
            this.panel1.Controls.Add(this.CbNguoiDieuHanh);
            this.panel1.Controls.Add(this.txtGiaVeNguoiLon);
            this.panel1.Controls.Add(this.txtGiaVeTreEm);
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(941, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 626);
            this.panel1.TabIndex = 17;
            // 
            // cbMaLichTrinh
            // 
            this.cbMaLichTrinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaLichTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLichTrinh.FormattingEnabled = true;
            this.cbMaLichTrinh.Location = new System.Drawing.Point(195, 151);
            this.cbMaLichTrinh.Name = "cbMaLichTrinh";
            this.cbMaLichTrinh.Size = new System.Drawing.Size(199, 28);
            this.cbMaLichTrinh.TabIndex = 28;
            // 
            // numTongSLVe
            // 
            this.numTongSLVe.Location = new System.Drawing.Point(196, 461);
            this.numTongSLVe.Name = "numTongSLVe";
            this.numTongSLVe.Size = new System.Drawing.Size(198, 22);
            this.numTongSLVe.TabIndex = 27;
            // 
            // dtpNgayKH
            // 
            this.dtpNgayKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayKH.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKH.Location = new System.Drawing.Point(195, 289);
            this.dtpNgayKH.Name = "dtpNgayKH";
            this.dtpNgayKH.Size = new System.Drawing.Size(199, 26);
            this.dtpNgayKH.TabIndex = 26;
            this.dtpNgayKH.ValueChanged += new System.EventHandler(this.dtpNgayKH_ValueChanged);
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayVe.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVe.Location = new System.Drawing.Point(195, 333);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(199, 26);
            this.dtpNgayVe.TabIndex = 26;
            // 
            // cbKH
            // 
            this.cbKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Items.AddRange(new object[] {
            "Bắc Giang",
            "Bắc Kạn",
            "Cao Bằng",
            "Hà Giang",
            "Lạng Sơn",
            "Phú Thọ",
            "Quảng Ninh",
            "Thái Nguyên",
            "Tuyên Quang",
            "Điện biên",
            "Hòa Bình",
            "Lai Châu",
            "Lào Cai",
            "Sơn La",
            "Yên Bái",
            "Bắc Ninh",
            "Hà Nam",
            "Hà Nội",
            "Hải Dương",
            "Thành phố Hải Phòng",
            "Hưng Yên",
            "Nam Định",
            "Ninh Bình",
            "Thái Bình",
            "Vĩnh Phúc",
            "Hà Tĩnh",
            "Nghệ An",
            "Quảng Bình",
            "Quảng Trị",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Bình Định",
            "Bình Thuận",
            "Thành phố Đà Nẵng",
            "Khánh Hòa",
            "Ninh Thuận",
            "Phú Yên",
            "Quảng Ngãi",
            "Quảng Nam",
            "Đắk Lắk",
            "Đắk Nông",
            "Gia Lai",
            "Kon Tum",
            "Lâm Đồng",
            "Bà Rịa Vũng Tàu",
            "Bình Dương",
            "Bình Phước",
            "Đồng Nai",
            "TPHCM",
            "Tây Ninh",
            "An Giang",
            "Bạc Liêu",
            "Bến Tre",
            "Cà Mau",
            "Thành phố Cần Thơ",
            "Đồng Tháp",
            "Hậu Giang",
            "Kiên Giang",
            "Long An",
            "Sóc Trăng",
            "Tiền Giang",
            "Trà Vinh",
            "Vĩnh Long"});
            this.cbKH.Location = new System.Drawing.Point(195, 197);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(199, 28);
            this.cbKH.TabIndex = 25;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTinhTrang.Enabled = false;
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Tour Đang Thực Hiện",
            "Tour Đã Xong"});
            this.cbTinhTrang.Location = new System.Drawing.Point(196, 502);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(198, 28);
            this.cbTinhTrang.TabIndex = 25;
            // 
            // CbNguoiDieuHanh
            // 
            this.CbNguoiDieuHanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbNguoiDieuHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbNguoiDieuHanh.FormattingEnabled = true;
            this.CbNguoiDieuHanh.Location = new System.Drawing.Point(195, 243);
            this.CbNguoiDieuHanh.Name = "CbNguoiDieuHanh";
            this.CbNguoiDieuHanh.Size = new System.Drawing.Size(199, 28);
            this.CbNguoiDieuHanh.TabIndex = 25;
            // 
            // txtGiaVeNguoiLon
            // 
            this.txtGiaVeNguoiLon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaVeNguoiLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVeNguoiLon.Location = new System.Drawing.Point(196, 418);
            this.txtGiaVeNguoiLon.Name = "txtGiaVeNguoiLon";
            this.txtGiaVeNguoiLon.Size = new System.Drawing.Size(198, 26);
            this.txtGiaVeNguoiLon.TabIndex = 24;
            this.txtGiaVeNguoiLon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaVeNguoiLon_KeyPress);
            // 
            // txtGiaVeTreEm
            // 
            this.txtGiaVeTreEm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaVeTreEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVeTreEm.Location = new System.Drawing.Point(195, 376);
            this.txtGiaVeTreEm.Name = "txtGiaVeTreEm";
            this.txtGiaVeTreEm.Size = new System.Drawing.Size(199, 26);
            this.txtGiaVeTreEm.TabIndex = 24;
            this.txtGiaVeTreEm.TextChanged += new System.EventHandler(this.txtGiaVeTreEm_TextChanged);
            this.txtGiaVeTreEm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaVeTreEm_KeyPress);
            // 
            // txtMaTour
            // 
            this.txtMaTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTour.Enabled = false;
            this.txtMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTour.Location = new System.Drawing.Point(195, 110);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(199, 26);
            this.txtMaTour.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(31, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Mã Tour: ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.UseMnemonic = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(31, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Mã Lịch Trình: ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.UseMnemonic = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(31, 510);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 20);
            this.label23.TabIndex = 23;
            this.label23.Text = "Tình Trạng: ";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.UseMnemonic = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(31, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Ngày Khởi Hành: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.UseMnemonic = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(31, 463);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Tổng Số Lượng Vé: ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.UseMnemonic = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(31, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Người Điều Hành: ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.UseMnemonic = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(31, 418);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 20);
            this.label21.TabIndex = 23;
            this.label21.Text = "Giá Vé Người Lớn: ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.UseMnemonic = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(31, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Điểm Khởi Hành: ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.UseMnemonic = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(31, 379);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Giá Vé Trẻ Em: ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.UseMnemonic = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(31, 339);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Ngày Về: ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.UseMnemonic = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(128)))));
            this.label20.Location = new System.Drawing.Point(29, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(235, 36);
            this.label20.TabIndex = 19;
            this.label20.Text = "Thông tin chi tiết";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(395, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 48);
            this.button3.TabIndex = 18;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(280, 604);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(109, 48);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(165, 604);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 48);
            this.btSua.TabIndex = 20;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(50, 604);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 48);
            this.btThem.TabIndex = 21;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1395, 685);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvTour);
            this.Controls.Add(this.labelTiltle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FTour";
            this.Text = "FTour";
            this.Load += new System.EventHandler(this.FTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongSLVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTiltle;
        private System.Windows.Forms.DataGridView gvTour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayVe;
        private System.Windows.Forms.ComboBox CbNguoiDieuHanh;
        private System.Windows.Forms.TextBox txtGiaVeNguoiLon;
        private System.Windows.Forms.TextBox txtGiaVeTreEm;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.DateTimePicker dtpNgayKH;
        private System.Windows.Forms.NumericUpDown numTongSLVe;
        private System.Windows.Forms.ComboBox cbMaLichTrinh;
    }
}