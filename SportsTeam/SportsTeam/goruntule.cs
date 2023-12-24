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
    public partial class goruntule : Form
    {
        public goruntule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TakimlariGoruntule eklegecis = new TakimlariGoruntule();
            eklegecis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FutbolculariGoruntule eklegecis = new FutbolculariGoruntule();
            eklegecis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GolKraliGoruntule eklegecis = new GolKraliGoruntule();
            eklegecis.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MacSonucuGoruntule eklegecis = new MacSonucuGoruntule();
            eklegecis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AsistKraliGoruntule eklegecis = new AsistKraliGoruntule();
            eklegecis.Show();
        }
    }
}
