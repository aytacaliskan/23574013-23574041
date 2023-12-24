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
    public partial class AsistKraliGoruntule : Form
    {
        string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

        public AsistKraliGoruntule()
        {
            InitializeComponent();
            LoadData();
        }

        private void AsistKraliGoruntule_Load(object sender, EventArgs e)
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
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 10\r\n    p.FirstName,p.LastName,\r\n    SUM(AssistsCount) AS ToplamAsist\r\nFROM\r\n    AssistsPlayers gp \r\n\tinner join Players p on p.PlayerID=gp.PlayerID\r\nGROUP BY\r\n    p.LastName,p.FirstName\r\nORDER BY\r\n    ToplamAsist DESC;", connection))
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
