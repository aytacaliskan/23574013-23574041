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
    public partial class GolKraliGoruntule : Form
    {
        string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

        public GolKraliGoruntule()
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
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 10\r\n    p.FirstName,p.LastName,\r\n    SUM(GoalCount) AS ToplamGol\r\nFROM\r\n    GoalPlayers gp \r\n\tinner join Players p on p.PlayerID=gp.PlayerID\r\nGROUP BY\r\n    p.LastName,p.FirstName\r\nORDER BY\r\n    ToplamGol DESC;", connection))
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

        private void GolKraliGoruntule_Load(object sender, EventArgs e)
        {

        }
    }
}
