using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsTeam
{
    public partial class SezonEkle : Form
    {
        public SezonEkle()
        {
            InitializeComponent();
        }

        private void SezonEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sportsTeamDataSet.Seasons' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seasonsTableAdapter.Fill(this.sportsTeamDataSet.Seasons);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

            // SqlConnection nesnesi oluşturulması
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sezon = textBox1.Text;

                try
                {
                    // Veritabanı bağlantısının açılması
                    connection.Open();

                    // SqlCommand nesnesi oluşturulması
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        // SQL sorgusu (INSERT INTO Ögrenciler (Isim) VALUES (@Isim))
                        cmd.CommandText = "INSERT INTO Seasons values (@Isim)";
                        cmd.Connection = connection;

                        // Parametre eklenmesi
                        cmd.Parameters.AddWithValue("@Isim", sezon);

                        // SQL komutunun çalıştırılması
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Sezon başarıyla eklendi.");
                            dataGridView1.Refresh();

                        }
                        else
                        {
                            MessageBox.Show("Sezon eklenirken bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
