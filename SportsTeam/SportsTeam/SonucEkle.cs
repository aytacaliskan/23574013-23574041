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
    public partial class SonucEkle : Form
    {
        string connectionString = "Data Source=DESKTOP-S6N80DU\\SQLEXPRESS;Initial Catalog=SportsTeam;Integrated Security=True";

        public SonucEkle()
        {
            InitializeComponent();
            FillComboBox();
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
                        takim1CB.DataSource = dataTable;

                        // ComboBox'ta görünen metin
                        takim1CB.DisplayMember = "TeamName";

                        // ComboBox'ta seçilen değerin arka plandaki değeri
                        takim1CB.ValueMember = "TeamID";

                    }

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TeamID,TeamName FROM Teams", connection))
                    {
                        // DataTable oluştur
                        DataTable dataTable = new DataTable();

                        // DataTable'ı doldur
                        dataAdapter.Fill(dataTable);

                        // ComboBox'a DataTable'ı bağla
                        takim2CB.DataSource = dataTable;

                        // ComboBox'ta görünen metin
                        takim2CB.DisplayMember = "TeamName";

                        // ComboBox'ta seçilen değerin arka plandaki değeri
                        takim2CB.ValueMember = "TeamID";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void SonucEkle_Load(object sender, EventArgs e)
        {
            LoadData();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
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
                    using (SqlCommand cmd = new SqlCommand("select TeamsHome.TeamName,TeamsAway.TeamName,CONCAT(Matches.homeGoals, '-', Matches.awayGoals) AS Sonuc,Matches.matchDate from Matches\r\nINNER JOIN Teams TeamsHome ON Matches.HomeTeamID = TeamsHome.TeamID\r\nINNER JOIN Teams TeamsAway ON Matches.AwayID = TeamsAway.TeamID\r\n", connection))
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
        private void btnSonucEkle_Click(object sender, EventArgs e)
        {
            int ilktakimIndeks = takim1CB.SelectedIndex;
            ilktakimIndeks++;
            int ikincitakimIndeks = takim2CB.SelectedIndex;
            ikincitakimIndeks++;
            DateTime selectedDate = dateTimePicker2.Value;
            String evSahibiGol = evGol.Text;
            String deplasmanGol = depGol.Text;
            String evinAsist = evAsist.Text;
            String deplasmanAsist = depAsist.Text;
            String tarih = selectedDate.ToString();
            tarih=tarih.Replace(".","-");
            tarih = tarih.Substring(6, 4)+"-"+tarih.Substring(3, 2)+"-"+tarih.Substring(0, 2)+" " +tarih.Substring(11);

            MessageBox.Show(tarih);

            string formattedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // SQL sorgusunu oluştur
            string sqlQuery = $"INSERT INTO Matches VALUES ({ilktakimIndeks}, {ikincitakimIndeks}, '{formattedDate}', {evSahibiGol}, {deplasmanGol}, {evinAsist}, {deplasmanAsist})";

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
