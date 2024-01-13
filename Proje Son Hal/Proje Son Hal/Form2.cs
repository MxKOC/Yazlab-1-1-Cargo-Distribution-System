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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proje_Son_Hal
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection conn;

        public Form2()
        {

            InitializeComponent();
            instance = this;
            

            noktalar = new List<PointLatLng>();

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

        private List<PointLatLng> noktalar;
        int s = 0;
        private List<List<int>> permutasyonlar = new List<List<int>>();
        private List<int> permutyedek = new List<int>();
        int index;
        int reset = 0;
        int reset2 = 0;
        int reset3 = 0;




        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        private void Form2_Load(object sender, EventArgs e)
        {

            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB1SIJQvnHJF45adoM3hZcU2_sdyBCeWDg";


            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;

        }





        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public void hedef(double x, double y)
        {
            //Ekleme İşlemi

            int maxID = maxIdAra() + 1;
            Console.WriteLine(x);
            string sorgu = "INSERT INTO `kargolar` (`kargoID`, `kordinatx`, `kordinaty`, `teslimatDurumu`) " +
                "VALUES ('" + maxID + "', '" + x + "', '" + y + "', '0')";
            ESG(sorgu);

            PointLatLng point = new PointLatLng(x, y);
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);


            noktalar.Add(new PointLatLng(point.Lat, point.Lng));

        }


        public void kullanici(double xx, double yy)
        {



            map.Position = new PointLatLng(xx, yy);
            map.MinZoom = 1;
            map.MaxZoom = 18;
            map.Zoom = 10;


            PointLatLng point = new PointLatLng(xx, yy);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.purple_pushpin);
            GMapOverlay markers = new GMapOverlay("xxyy");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

            noktalar.Add(new PointLatLng(xx, yy));

            map.Refresh();
            Console.Write(xx);
            Console.Write(" , ");
            Console.WriteLine(yy);

        }





        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void button3_Click(object sender, EventArgs e)
        {





            Thread th = new Thread(() =>
            {
                int id = -1;
                string sorgu2 = "";
                int sayac = 0;


                while (noktalar.Count >= 2)
                {
                    Rota();
                    Thread.Sleep(5000);

                    for (int i = 0; i < noktalar.Count - 1; i++)
                        map.Overlays.RemoveAt(map.Overlays.Count - 1);

                    PointLatLng nokta = noktalar[permutyedek[0]];
                    noktalar.RemoveAt(permutyedek[0]);
                    map.Overlays.RemoveAt(permutyedek[0]);

                    for (int i = 0; i < permutyedek.Count; i++)
                    {

                        if (permutyedek[i] > permutyedek[0])
                        {
                            permutyedek[i]--;
                        }


                    }
                    permutyedek.RemoveAt(0);


                    if(sayac != 0)
                    {
                        // Kargonun teslimat durumu değiştirilecek. Öncelikle değiştirilecek noktanın id si bulunuyor.
                        string sorgu = "SELECT kargoID FROM kargolar Where kordinatx = '" + nokta.Lat + "' and kordinaty = '" + nokta.Lng + "';";
                        id = idAra(sorgu);
                        Console.WriteLine(id);
                        //Sonra değiştirme işlemi yapılıyor.
                        sorgu2 = "UPDATE kargolar SET teslimatDurumu = '1' Where kargoID = " + id;
                        ESG(sorgu2);
                    }
                    sayac++;
                }

                string sorgu3 = "Select kargoID From kargolar Where teslimatDurumu = 0";
                int id2 = idAra(sorgu3);


                sorgu2 = "UPDATE kargolar SET teslimatDurumu = '1' Where kargoID = " + id2;
                ESG(sorgu2);



                map.Overlays.RemoveAt(permutyedek[0]);


            });
            th.Start();


        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void button1_Click(object sender, EventArgs e)
        {



            Thread th2 = new Thread(() =>
            {





                double[,] yollar = new double[noktalar.Count, noktalar.Count];
                int k1 = 0;
                foreach (PointLatLng x1 in noktalar)
                {
                    int k2 = 0;
                    foreach (PointLatLng x2 in noktalar)
                    {


                        var routex = GoogleMapProvider.Instance.GetRoute(x1, x2, false, false, 14);

                        yollar[k1, k2] = routex.Distance;


                        k2++;
                    }

                    k1++;

                }




                int V = noktalar.Count;

                List<int> gecici = new List<int>();

                List<int> liste1 = new List<int>();
                List<double> toluyol = new List<double>();
                gecici = Enumerable.Range(0, V).ToList();

                int[] liste2 = new int[V - 1];


                foreach (int i in gecici)
                {

                    if (i != s)
                    {
                        liste1.Add(i);
                    }

                }

                for (int x = 0; x < liste1.Count; x++)
                {


                    liste2[x] = liste1[x];
                    Console.WriteLine(liste2[x]);


                }

                double minyol = 999999;

                //List<List<int>> permutasyonlar = new List<List<int>>();

                permutasyonlar = Permute(liste2);






                foreach (List<int> i in permutasyonlar)
                {


                    double yol_uzunluk = 0;

                    int k = 0;

                    foreach (int j in i)
                    {

                        yol_uzunluk += yollar[k, j];
                        k = j;
                    }



                    toluyol.Add(yol_uzunluk);


                    minyol = Math.Min(minyol, yol_uzunluk);
                }
                double kucuk = toluyol.Min();
                index = toluyol.IndexOf(kucuk);

                permutyedek.Add(0);
                permutyedek.AddRange(permutasyonlar[index]);


            });
            th2.Start();



        }//                 En kısa yol bulunuyor


        static List<List<int>> Permute(int[] nums)
        {
            var list = new List<List<int>>();
            return DoPermute(nums, 0, nums.Length - 1, list);
        }

        static List<List<int>> DoPermute(int[] nums, int start, int end, List<List<int>> list)
        {
            if (start == end)
            {
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }




        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        private void Rota()
        {






            for (int x = 0; x < permutyedek.Count - 1; x++)
            {

                var route2 = GoogleMapProvider.Instance.GetRoute(noktalar[permutyedek[x]], noktalar[permutyedek[x + 1]], false, false, 14);

                var r2 = new GMapRoute(route2.Points, "My route2");

                var routes2 = new GMapOverlay("routes2");

                routes2.Routes.Add(r2);
                map.Overlays.Add(routes2);


            }

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
                    string sorgu = "Select max(kargoID) From kargolar";
                    MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                    MySqlDataReader mdr = cmd.ExecuteReader();
                    int id = 0;
                    mdr.Read();
                    if (mdr["max(kargoID)"].ToString() == "")
                    {
                        return id;
                    }
                    else
                    {
                        id = int.Parse(mdr["max(kargoID)"].ToString());

                        return id;
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    return -1;
                }
            }
        }

        public int idAra(string sorgu)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                    MySqlDataReader mdr = cmd.ExecuteReader();
                    //int id = int.Parse(mdr.Read().ToString());
                    mdr.Read();
                    int id = -1;
                    id = int.Parse(mdr["kargoID"].ToString());
                    return id;
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    return -1;
                }
            }
        }
    }
}
