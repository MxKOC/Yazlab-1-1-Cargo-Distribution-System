
namespace Proje_Son_Hal
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.txtlong = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kuly = new System.Windows.Forms.TextBox();
            this.kulx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txt3Name = new System.Windows.Forms.TextBox();
            this.txt3Password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txt2EskiP = new System.Windows.Forms.TextBox();
            this.txt2YeniP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSifre = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txt2YeniPT = new System.Windows.Forms.TextBox();
            this.lblSorgu = new System.Windows.Forms.Label();
            this.lbl2Sifre = new System.Windows.Forms.Label();
            this.lbl3Yeni = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1228, 751);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1228, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtlat
            // 
            this.txtlat.Location = new System.Drawing.Point(1228, 625);
            this.txtlat.Margin = new System.Windows.Forms.Padding(4);
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(169, 22);
            this.txtlat.TabIndex = 6;
            // 
            // txtlong
            // 
            this.txtlong.Location = new System.Drawing.Point(1228, 681);
            this.txtlong.Margin = new System.Windows.Forms.Padding(4);
            this.txtlong.Name = "txtlong";
            this.txtlong.Size = new System.Drawing.Size(169, 22);
            this.txtlong.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1091, 1055);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(16, 15);
            this.gmap.Margin = new System.Windows.Forms.Padding(4);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1058, 939);
            this.gmap.TabIndex = 9;
            this.gmap.Zoom = 0D;
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1203, 108);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 22);
            this.txtName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1166, 628);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "X :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1166, 690);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Y :";
            // 
            // kuly
            // 
            this.kuly.Location = new System.Drawing.Point(1228, 409);
            this.kuly.Margin = new System.Windows.Forms.Padding(4);
            this.kuly.Name = "kuly";
            this.kuly.Size = new System.Drawing.Size(169, 22);
            this.kuly.TabIndex = 19;
            // 
            // kulx
            // 
            this.kulx.Location = new System.Drawing.Point(1228, 349);
            this.kulx.Margin = new System.Windows.Forms.Padding(4);
            this.kulx.Name = "kulx";
            this.kulx.Size = new System.Drawing.Size(169, 22);
            this.kulx.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1166, 409);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Y :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1166, 347);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "X :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1160, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "KULLANICI GİRİŞİ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1203, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(133, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1104, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kullanıcı Adı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1151, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Şifre :";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(1216, 189);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(104, 31);
            this.btnGiris.TabIndex = 28;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txt3Name
            // 
            this.txt3Name.Location = new System.Drawing.Point(1466, 108);
            this.txt3Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt3Name.Name = "txt3Name";
            this.txt3Name.Size = new System.Drawing.Size(133, 22);
            this.txt3Name.TabIndex = 12;
            // 
            // txt3Password
            // 
            this.txt3Password.Location = new System.Drawing.Point(1466, 148);
            this.txt3Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt3Password.Name = "txt3Password";
            this.txt3Password.PasswordChar = '*';
            this.txt3Password.Size = new System.Drawing.Size(133, 22);
            this.txt3Password.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1389, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "YENİ HESAP AÇMA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1367, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Kullanıcı Adı :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1414, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Şifre :";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(1479, 189);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(104, 31);
            this.btnYeni.TabIndex = 28;
            this.btnYeni.Text = "KAYDOL";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txt2EskiP
            // 
            this.txt2EskiP.Location = new System.Drawing.Point(1768, 108);
            this.txt2EskiP.Margin = new System.Windows.Forms.Padding(4);
            this.txt2EskiP.Name = "txt2EskiP";
            this.txt2EskiP.PasswordChar = '*';
            this.txt2EskiP.Size = new System.Drawing.Size(133, 22);
            this.txt2EskiP.TabIndex = 12;
            // 
            // txt2YeniP
            // 
            this.txt2YeniP.Location = new System.Drawing.Point(1768, 148);
            this.txt2YeniP.Margin = new System.Windows.Forms.Padding(4);
            this.txt2YeniP.Name = "txt2YeniP";
            this.txt2YeniP.PasswordChar = '*';
            this.txt2YeniP.Size = new System.Drawing.Size(133, 22);
            this.txt2YeniP.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(1691, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 25);
            this.label15.TabIndex = 26;
            this.label15.Text = "ŞİFRE DEĞİŞTİRME";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1688, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Eski şifre :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1686, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 27;
            this.label17.Text = "Yeni şifre :";
            // 
            // btnSifre
            // 
            this.btnSifre.Location = new System.Drawing.Point(1784, 235);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(104, 31);
            this.btnSifre.TabIndex = 28;
            this.btnSifre.Text = "DEĞİŞTİR";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1639, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Yeni şifre(tekrar) :";
            // 
            // txt2YeniPT
            // 
            this.txt2YeniPT.Location = new System.Drawing.Point(1770, 186);
            this.txt2YeniPT.Margin = new System.Windows.Forms.Padding(4);
            this.txt2YeniPT.Name = "txt2YeniPT";
            this.txt2YeniPT.PasswordChar = '*';
            this.txt2YeniPT.Size = new System.Drawing.Size(133, 22);
            this.txt2YeniPT.TabIndex = 12;
            // 
            // lblSorgu
            // 
            this.lblSorgu.AutoSize = true;
            this.lblSorgu.ForeColor = System.Drawing.Color.Red;
            this.lblSorgu.Location = new System.Drawing.Point(1104, 83);
            this.lblSorgu.Name = "lblSorgu";
            this.lblSorgu.Size = new System.Drawing.Size(0, 17);
            this.lblSorgu.TabIndex = 29;
            // 
            // lbl2Sifre
            // 
            this.lbl2Sifre.AutoSize = true;
            this.lbl2Sifre.Location = new System.Drawing.Point(1688, 83);
            this.lbl2Sifre.Name = "lbl2Sifre";
            this.lbl2Sifre.Size = new System.Drawing.Size(0, 17);
            this.lbl2Sifre.TabIndex = 30;
            // 
            // lbl3Yeni
            // 
            this.lbl3Yeni.AutoSize = true;
            this.lbl3Yeni.Location = new System.Drawing.Point(1367, 83);
            this.lbl3Yeni.Name = "lbl3Yeni";
            this.lbl3Yeni.Size = new System.Drawing.Size(0, 17);
            this.lbl3Yeni.TabIndex = 31;
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(1448, 348);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(453, 556);
            this.grid.TabIndex = 32;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(1823, 312);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(78, 30);
            this.btnYenile.TabIndex = 33;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1138, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "DAĞITIM MERKEZİ KONUMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1193, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "KARGO KONUMU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lbl3Yeni);
            this.Controls.Add(this.lbl2Sifre);
            this.Controls.Add(this.lblSorgu);
            this.Controls.Add(this.btnSifre);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kuly);
            this.Controls.Add(this.kulx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2YeniPT);
            this.Controls.Add(this.txt2YeniP);
            this.Controls.Add(this.txt3Password);
            this.Controls.Add(this.txt2EskiP);
            this.Controls.Add(this.txt3Name);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtlong);
            this.Controls.Add(this.txtlat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.TextBox txtlong;
        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kuly;
        private System.Windows.Forms.TextBox kulx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txt3Name;
        private System.Windows.Forms.TextBox txt3Password;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txt2EskiP;
        private System.Windows.Forms.TextBox txt2YeniP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt2YeniPT;
        private System.Windows.Forms.Label lblSorgu;
        private System.Windows.Forms.Label lbl2Sifre;
        private System.Windows.Forms.Label lbl3Yeni;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

