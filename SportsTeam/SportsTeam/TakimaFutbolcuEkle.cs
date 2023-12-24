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
    public partial class TakimaFutbolcuEkle : Form
    {
        string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

        public TakimaFutbolcuEkle()
        {
            InitializeComponent();
            FillComboBox();
            LoadData();

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

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter("select PlayerID,CONCAT(FirstName, ' ',LastName) AS AdSoyad from Players where PlayerID not in (select PlayerID from TeamPlayers)\r\n", connection))
                    {
                        // DataTable oluştur
                        DataTable dataTable = new DataTable();

                        // DataTable'ı doldur
                        dataAdapter.Fill(dataTable);

                        // ComboBox'a DataTable'ı bağla
                        comboBox2.DataSource = dataTable;

                        // ComboBox'ta görünen metin
                        comboBox2.DisplayMember = "AdSoyad";

                        // ComboBox'ta seçilen değerin arka plandaki değeri
                        comboBox2.ValueMember = "PlayerID";

                    }

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SeasonsID,SeasonsName FROM Seasons", connection))
                    {
                        // DataTable oluştur
                        DataTable dataTable = new DataTable();

                        // DataTable'ı doldur
                        dataAdapter.Fill(dataTable);

                        // ComboBox'a DataTable'ı bağla
                        comboBox3.DataSource = dataTable;

                        // ComboBox'ta görünen metin
                        comboBox3.DisplayMember = "SeasonsName";

                        // ComboBox'ta seçilen değerin arka plandaki değeri
                        comboBox3.ValueMember = "SeasonsID";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void TakimaFutbolcuEkle_Load(object sender, EventArgs e)
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
                    using (SqlCommand cmd = new SqlCommand("select tm.TeamName as 'Takım Adı',CONCAT(p.FirstName, ' ',p.LastName) AS 'Ad Soyad',SeasonsName as 'Sezon' from TeamPlayers tp \r\ninner join Teams tm on tm.TeamID=tp.TeamID\r\ninner join Seasons s on s.SeasonsID=tp.SeasonsID\r\ninner join Players p on p.PlayerID=tp.PlayerID", connection))
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedSeasonsID = (int)comboBox3.SelectedValue;
            int selectedTeamID = (int)comboBox1.SelectedValue;
            int selectedPlayerID = (int)comboBox2.SelectedValue;

            string sqlQuery = $"INSERT INTO TeamPlayers VALUES ({selectedTeamID}, {selectedSeasonsID},{selectedPlayerID})";

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
