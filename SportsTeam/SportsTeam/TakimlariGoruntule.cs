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
    public partial class TakimlariGoruntule : Form
    {
        string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

        public TakimlariGoruntule()
        {
            InitializeComponent();
            LoadData();
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
                    using (SqlCommand cmd = new SqlCommand("select t.TeamName,s.SeasonsName from TeamSeasons ts inner join Teams t on t.TeamID=ts.TeamID inner join Seasons s on s.SeasonsID=ts.SeasonsID", connection))
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
        private void TakimlariGoruntule_Load(object sender, EventArgs e)
        {

        }
    }
}
