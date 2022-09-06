using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TourDuLich
{
    class TourDL
    {
        public Panel gb;
        private PictureBox pic;
        private Label[] text;
        private PictureBox stars;
        private PictureBox Xoa;
        private Label xoaVe;
        public TourDL(Label[] text, PictureBox pic, int ToaDoy)
        {
            gb = new Panel();
            
            gb.Location = new System.Drawing.Point(483,ToaDoy);
            gb.Size = new System.Drawing.Size(680, 250);
            this.text = text;
            this.pic = pic;
            XemTour();
        }
        public TourDL(Label[] text,PictureBox stars , PictureBox pic, string k, int ToaDoy)
        {
            gb = new Panel();
            this.text = text;
            this.stars = stars;
            this.pic = pic;
            gb.Size = new System.Drawing.Size(1000, 350);
            gb.Location = new System.Drawing.Point(50, ToaDoy);
            setup(k);
        }

        public TourDL(Label[] text, PictureBox stars, PictureBox pic, PictureBox xoa, string maVe, int ToaDoy)
        {
            gb = new Panel();
            this.text = text;
            this.stars = stars;
            this.Xoa = xoa;
            this.pic = pic;
            this.xoaVe = new Label();
            gb.Size = new System.Drawing.Size(1200, 350);
            gb.Location = new System.Drawing.Point(100, ToaDoy);
            setup(maVe);
            XoaTour(maVe);
        }

        private void XoaTour(String maVe)
        {
           
            xoaVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            xoaVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            xoaVe.Font = new System.Drawing.Font("MTO Chaney", 19.2F, System.Drawing.FontStyle.Bold);
            xoaVe.ForeColor = System.Drawing.Color.Black;
            xoaVe.Margin = new System.Windows.Forms.Padding(0);
            xoaVe.Size = new System.Drawing.Size(185, 40);
            xoaVe.Text = "Hủy Vé";
            xoaVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            xoaVe.Location = new System.Drawing.Point(740, 280);
            this.xoaVe.Name = maVe;


            this.Xoa.BackColor = System.Drawing.Color.Red;
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);          
            this.Xoa.Size = new System.Drawing.Size(39, 39);
            this.Xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Xoa.TabStop = false;
            this.Xoa.Location = new System.Drawing.Point(753, 280);
        

            gb.Controls.Add(Xoa);
            gb.Controls.Add(xoaVe);
           


        }

        private void XemTour()
        {
            //picture
            this.pic.Size = new System.Drawing.Size(40, 40);
            this.pic.Location = new System.Drawing.Point(10, 0);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            //Ngày
            this.text[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.text[0].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text[0].Font = new System.Drawing.Font("MTO Chaney", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text[0].ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.text[0].Size = new System.Drawing.Size(166, 53);
            this.text[0].Location = new System.Drawing.Point(0, (this.gb.Height)/2-10); 
            this.text[0].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //heading
            this.text[1].BackColor = System.Drawing.Color.Transparent;
            this.text[1].Font = new System.Drawing.Font("MTO Chaney", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text[1].ForeColor = System.Drawing.Color.Black;
            this.text[1].Location = new System.Drawing.Point(50, 0);
            this.text[1].AutoSize = true;


            //text
            this.text[2].BackColor = System.Drawing.Color.Transparent;
            this.text[2].Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text[2].ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.text[2].Location = new System.Drawing.Point(176, 60);
            this.text[2].Margin = new System.Windows.Forms.Padding(0);
            this.text[2].Size = new System.Drawing.Size(470, 175);
            this.text[2].Name = this.text[0].Text.Split(' ')[1];


            //slash
            Label slash = new Label();
            slash.Text = "---------------------------------------------------------------------------------" +
    "----";
            slash.AutoSize = true;
            slash.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            slash.ForeColor = System.Drawing.Color.Orange;
            slash.Location = new System.Drawing.Point(0, 20);

            this.gb.Controls.Add(pic);
            this.gb.Controls.AddRange(text);
            this.gb.Controls.Add(slash);
        }
        private void setup(string k)
        {



            text[0].Name = k;
            this.text[0].Location = new System.Drawing.Point(95, 60);
            this.text[0].Font = new System.Drawing.Font("MTO Franko", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text[0].ForeColor = System.Drawing.Color.Chocolate;
            this.text[0].AutoSize = true;
            this.text[0].BringToFront();

            gb.Controls.Add(text[0]);
            for (int i = 1; i < this.text.Length; i++)
            {
                this.text[i].Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.text[i].ForeColor = System.Drawing.Color.SaddleBrown;
                this.text[i].AutoSize = true;

                this.text[i].Name = "text" + i.ToString() + k.ToString();
                if (i == 1)
                {
                    this.text[i].Location = new System.Drawing.Point(420, 180);
                }
                else if (i == 5)
                    this.text[i].Location = new System.Drawing.Point(740, 180);
                else
                    this.text[i].Location = new System.Drawing.Point(this.text[i - 1].Location.X, this.text[i - 1].Location.Y + 30);
            }
            

            //pic
            pic.Name = "picTour" + k.ToString();
            this.pic.Size = new System.Drawing.Size(301, 199);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Location = new System.Drawing.Point(90, 120);

            Label slash = new Label();
            slash.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------";
            slash.AutoSize = true;
            slash.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            slash.ForeColor = System.Drawing.Color.Orange;
            slash.Location = new System.Drawing.Point(92, 90);

            //date
            String[] ngay = this.text[2].Text.Split(':');
            String[] ngay2 = ngay[1].Split('/');
            Label date1 = new Label();

            date1.BackColor = System.Drawing.Color.Orange;
            date1.Font = new System.Drawing.Font("MTO Franko", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            date1.ForeColor = System.Drawing.Color.PapayaWhip;

            date1.Size = new System.Drawing.Size(91, 54);
            date1.Text = ngay2[0];
            date1.TextAlign = System.Drawing.ContentAlignment.TopCenter;



            Label date2 = new Label();

            date2.BackColor = System.Drawing.Color.Orange;
            date2.Font = new System.Drawing.Font("MTO Franko", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            date2.ForeColor = System.Drawing.Color.PapayaWhip;

            date2.Size = new System.Drawing.Size(91, 54);
            date2.Text = "-------";
            date2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            date2.Location = new System.Drawing.Point(0, 25);




            Label date3 = new Label();
            date3.BackColor = System.Drawing.Color.Orange;
            date3.Font = new System.Drawing.Font("MTO Franko", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            date3.ForeColor = System.Drawing.Color.PapayaWhip;

            date3.Size = new System.Drawing.Size(91, 43);
            date3.Text = ngay2[1] + "/" + ngay2[2].Substring(2);
            date3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            date3.Location = new System.Drawing.Point(0, 70);
            //Stars
            PictureBox[] st = new PictureBox[5];
            for(int i = 0; i < 5; i++)
            {
                st[i] = new PictureBox();
                st[i].Image = stars.Image;
                st[i].Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                st[i].Size = new System.Drawing.Size(47, 43);
                st[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                if(i == 0)
                    st[i].Location = new System.Drawing.Point(410, 120);
                else
                    st[i].Location = new System.Drawing.Point(st[i-1].Location.X+40, 120);
                st[i].BringToFront();
            }    



            gb.Controls.AddRange(text);
            gb.Controls.Add(pic);
            gb.Controls.Add(slash);
            gb.Controls.Add(date1);
            gb.Controls.Add(date2);
            gb.Controls.Add(date3);
            gb.Controls.AddRange(st);


        }

        public Label getHeading()
        {
            return this.text[0];
        }

        public Label getText()
        {
            return this.text[2];
        }
        public Label GetXoa()
        {
            return this.xoaVe;
        }
 
    }

}
