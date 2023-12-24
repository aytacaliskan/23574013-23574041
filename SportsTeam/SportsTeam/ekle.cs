using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsTeam
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TakimEkle eklegecis = new TakimEkle();
            eklegecis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FutbolcuEkle eklegecis = new FutbolcuEkle();
            eklegecis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TakimaFutbolcuEkle eklegecis = new TakimaFutbolcuEkle();
            eklegecis.Show();
        }

        private void ekle_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SezonEkle eklegecis = new SezonEkle();
            eklegecis.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SezonaTakimEkle eklegecis = new SezonaTakimEkle();
            eklegecis.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SonucEkle eklegecis = new SonucEkle();
            eklegecis.Show();

        }
    }
}
