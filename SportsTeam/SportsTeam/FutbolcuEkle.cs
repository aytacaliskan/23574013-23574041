using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SportsTeam
{
    public partial class FutbolcuEkle : Form
    {
        string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

        public FutbolcuEkle()
        {
            InitializeComponent();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {

            // Veritabanı bağlantı dizesi
         
            // SqlConnection nesnesi oluşturulması
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String ad = textBox1.Text;
                String soyad = textBox2.Text;
                String mevki = textBox3.Text;
                try
                {
                    // Veritabanı bağlantısının açılması
                    connection.Open();

                    // SqlCommand nesnesi oluşturulması
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        // SQL sorgusu (INSERT INTO Ögrenciler (Isim) VALUES (@Isim))
                        cmd.CommandText = "INSERT INTO Players values (@Isim,@SoyIsım,@Mevki)";
                        cmd.Connection = connection;

                        // Parametre eklenmesi
                        cmd.Parameters.AddWithValue("@Isim", ad);
                        cmd.Parameters.AddWithValue("@SoyIsım", soyad);
                        cmd.Parameters.AddWithValue("@Mevki", mevki);
                        // SQL komutunun çalıştırılması
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Futbolcu başarıyla eklendi.");
                            LoadData();

                        }
                        else
                        {
                            MessageBox.Show("Futbolcu eklenirken bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }          
        }

        private void FutbolcuEkle_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Veritabanı bağlantısının açılması
                    connection.Open();

                    // SqlCommand nesnesi oluşturulması
                    using (SqlCommand cmd = new SqlCommand("SELECT FirstName,LastName,Position FROM Players", connection))
                    {
                        // SqlDataAdapter kullanarak verileri çek
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            // DataTable oluştur
                            DataTable dataTable = new DataTable();

                            // DataTable'e verileri doldur
                            dataAdapter.Fill(dataTable);

                            // DataGridView'e DataTable'i bağla
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

    }
}
