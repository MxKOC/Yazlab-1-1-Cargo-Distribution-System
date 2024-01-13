using System;
using System.Collections.Generic;
using System.ComponentModel;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proje_Son_Hal
{
    public partial class Form1 : Form
    {
        Form2 f = new Form2();
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection conn;

        int res = 0;

        public Form1()
        {
            InitializeComponent();
            noktalar2 = new List<PointLatLng>();
            f.Show();

            builder.Server = "34.136.120.124";
            builder.UserID = "root";
            builder.Database = "proje";
            builder.Password = "12345";
            conn = new MySqlConnection(builder.ToString());

            using (conn)
            {
                try
                {
                    conn.Open();
                }

                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }

        }



        private List<PointLatLng> noktalar2;

        private void Form1_Load(object sender, EventArgs e)
        {

            double xx = 40.764157;
            double yy = 29.969865;


            gmap.Position = new PointLatLng(xx, yy);
            gmap.MinZoom = 1;
            gmap.MaxZoom = 18;
            gmap.Zoom = 10;


            PointLatLng point = new PointLatLng(xx, yy);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.purple_pushpin);
            GMapOverlay markers = new GMapOverlay("xxyy");
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);

            noktalar2.Add(new PointLatLng(xx, yy));



            gmap.DragButton = MouseButtons.Right;
            gmap.MapProvider = GMapProviders.GoogleMap;

            gmap.ShowCenter = false;


            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB1SIJQvnHJF45adoM3hZcU2_sdyBCeWDg";

            Listele();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double X1 = Convert.ToDouble(txtlat.Text);
            double Y1 = Convert.ToDouble(txtlong.Text);



            f.hedef(X1, Y1);
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double X1 = Convert.ToDouble(kulx.Text);
            double Y1 = Convert.ToDouble(kuly.Text);



            f.kullanici(X1, Y1);


        }






        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (res == 0)
                {
                    var pointkul = gmap.FromLocalToLatLng(e.X, e.Y);
                    double x2 = pointkul.Lat;
                    double y2 = pointkul.Lng;


                    kulx.Text = x2.ToString();
                    kuly.Text = y2.ToString();

                    res++;
                }
                res++;



                if (res > 2)
                {

                    var point = gmap.FromLocalToLatLng(e.X, e.Y);
                    double X1 = point.Lat;
                    double Y1 = point.Lng;


                    txtlat.Text = X1.ToString();
                    txtlong.Text = Y1.ToString();


                }
            }
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtName.Text;
            string kullaniciSifre = txtPassword.Text;
            string kullaniciId;

            kullaniciId = Sorgula(kullaniciAdi, kullaniciSifre);

            if (kullaniciId != "-1")
            {
                lblSorgu.Text = "Başarıyla giriş yapıldı.";
                lblSorgu.ForeColor = Color.Green;
                txtName.Text = "";
                txtPassword.Text = "";
                await Task.Delay(2000);
                lblSorgu.Text = "";
            }
            else
            {
                lblSorgu.ForeColor = Color.Red;
                lblSorgu.Text = "Şifre ya da kullanıcı adı hatalı.";
                txtName.Text = "";
                txtPassword.Text = "";
                await Task.Delay(2000);
                lblSorgu.Text = "";
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniHesap();
        }

        private async void btnSifre_Click(object sender, EventArgs e)
        {
            if (txt2YeniP.Text != txt2YeniPT.Text)
            {
                lbl2Sifre.Text = "Yeni şifreniz tekrarıyla eşleşmiyor.";
                lbl2Sifre.ForeColor = Color.Red;
                txt2EskiP.Text = "";
                txt2YeniP.Text = "";
                txt2YeniPT.Text = "";
                await Task.Delay(2000);
                lbl2Sifre.Text = "";
            }
            else
            {
                string sorgu = "Select kullaniciID From kullanici Where kullaniciSifre = " + txt2EskiP.Text;
                int id = -1;

                //Şifreye göre id araması yapılıyor.
                using (conn)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                        MySqlDataReader mdr = cmd.ExecuteReader();
                        //int id = int.Parse(mdr.Read().ToString());
                        mdr.Read();
                        id = int.Parse(mdr["kullaniciID"].ToString());
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }

                string sorgu2 = "UPDATE kullanici SET kullaniciSifre = '" + txt2YeniP.Text + "' Where kullaniciID = " + id;
                ESG(sorgu2);

                lbl2Sifre.Text = "Şifreniz başarıyla Değiştirildi.";
                lbl2Sifre.ForeColor = Color.Green;
                txt2EskiP.Text = "";
                txt2YeniP.Text = "";
                txt2YeniPT.Text = "";
                await Task.Delay(2000);
                lbl2Sifre.Text = "";
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        //Kullanıcının girdiği şifre ve ismin veritabanında olup olmadığı kontrol ediliyor.
        public string Sorgula(string ad, string sifre)
        {
            string sorgu = "Select kullaniciID From kullanici Where kullaniciAdi = '" + ad + "' and kullaniciSifre = '" + sifre + "'";
            string id = "-1";

            using (conn)
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                    MySqlDataReader mdr = cmd.ExecuteReader();
                    string value = mdr.Read().ToString();
                    Console.WriteLine(value);

                    if (value != "False")
                    {
                        id = value;
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }

            return id;
        }

        public async void YeniHesap()
        {
            int id = maxIdAra() + 1;
            string kullaniciAdi = txt3Name.Text;
            string kullaniciSifre = txt3Password.Text;

            string sorgu = "INSERT INTO `kullanici` (`kullaniciID`, `kullaniciAdi`, `kullaniciSifre`) VALUES " +
            "('" + id + "', '" + kullaniciAdi + "', '" + kullaniciSifre + "')";
            Console.WriteLine(sorgu);

            ESG(sorgu);
            lbl3Yeni.ForeColor = Color.Green;
            lbl3Yeni.Text = "Başarıyla kaydoldunuz.";
            txt3Name.Text = "";
            txt3Password.Text = "";
            await Task.Delay(2000);
            lbl3Yeni.Text = "";
        }

        //Veritabanına ekleme , silme ve güncelleme işlemlerini içeren fonksiyon.
        public void ESG(string sorgu)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sorgu;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        //En yüksek değerlikli id'yi bulup döndürüyor.
        public int maxIdAra()
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    string sorgu = "Select max(kullaniciID) From kullanici";
                    MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                    MySqlDataReader mdr = cmd.ExecuteReader();
                    int id;
                    //int id = int.Parse(mdr.Read().ToString());
                    mdr.Read();
                    id = int.Parse(mdr["max(kullaniciID)"].ToString());

                    return id;
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    return -1;
                }
            }
        }

        //Kargolar tablosundaki değerlerin listelenmesi sağlanacak.
        public void Listele()
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    DataTable tbl = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From kargolar", conn);
                    adapter.Fill(tbl);
                    grid.DataSource = tbl;

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }


    }
}

