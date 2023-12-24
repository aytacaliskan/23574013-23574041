using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SportsTeam
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void conn_Click(object sender, EventArgs e)
        {

            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

            // SqlConnection nesnesi oluşturulması
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Veritabanı bağlantısının açılması
                    connection.Open();

                    // SqlCommand nesnesi oluşturulması
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        // SQL sorgusu (INSERT INTO Ögrenciler (Isim) VALUES (@Isim))
                        cmd.CommandText = "INSERT INTO Seasons values ('aytac')";
                        cmd.Connection = connection;

                        // Parametre eklenmesi
                        cmd.Parameters.AddWithValue("@Isim", "aytac");

                        // SQL komutunun çalıştırılması
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Öğrenci başarıyla eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci eklenirken bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekle eklegecis=new ekle ();
            eklegecis.Show();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            goruntule goruntuleGecis = new goruntule();
            goruntuleGecis.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
