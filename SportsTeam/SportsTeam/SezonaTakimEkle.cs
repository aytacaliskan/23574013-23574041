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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SportsTeam
{
    public partial class SezonaTakimEkle : Form
    {
        string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

        public SezonaTakimEkle()
        {
            InitializeComponent();
            FillComboBox();
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
        private void FillComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Veritabanından veri çekmek için bir SqlDataAdapter kullan
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TeamID,TeamName FROM Teams", connection))
                    {
                        // DataTable oluştur
                        DataTable dataTable = new DataTable();

                        // DataTable'ı doldur
                        dataAdapter.Fill(dataTable);

                        // ComboBox'a DataTable'ı bağla
                        comboBox1.DataSource = dataTable;

                        // ComboBox'ta görünen metin
                        comboBox1.DisplayMember = "TeamName";

                        // ComboBox'ta seçilen değerin arka plandaki değeri
                        comboBox1.ValueMember = "TeamID";

                    }

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter("select SeasonsID,SeasonsName from Seasons", connection))
                    {
                        // DataTable oluştur
                        DataTable dataTable = new DataTable();

                        // DataTable'ı doldur
                        dataAdapter.Fill(dataTable);

                        // ComboBox'a DataTable'ı bağla
                        comboBox2.DataSource = dataTable;

                        // ComboBox'ta görünen metin
                        comboBox2.DisplayMember = "SeasonsName";

                        // ComboBox'ta seçilen değerin arka plandaki değeri
                        comboBox2.ValueMember = "SeasonsID";

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void SezonaTakimEkle_Load(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            int selectedSeasonsID = (int)comboBox2.SelectedValue;
            int selectedTeamID = (int)comboBox1.SelectedValue;

            string sqlQuery = $"INSERT INTO TeamSeasons VALUES ({selectedTeamID}, {selectedSeasonsID})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla eklendi.");
                            LoadData();

                        }
                        else
                        {
                            MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
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
