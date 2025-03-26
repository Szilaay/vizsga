using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmekGUI
{
    public partial class Form1 : Form
    {
        void betoltes()
        {
            dgAdatok.Rows.Clear();

            string kereses = "";
            if(txKereses.TextLength > 0)
            {
                kereses = " WHERE nev LIKE '" + txKereses.Text + "%'";
            }

            string kereses2 = "";
            if (cbNemzet.SelectedIndex > 0)
            {
                kereses2 = " WHERE nemzet = '" + cbNemzet.SelectedItem.ToString() + "'";
            }

            string sql = "SELECT * FROM szinesz" + kereses + kereses2 +  " order by nev";
            Adatbazis ab = new Adatbazis(sql);

            while (ab.Dr.Read())
            {
                dgAdatok.Rows.Add(ab.Dr["nev"], Convert.ToDateTime(ab.Dr["szuldatum"]).ToString("yyyy-MM-dd"), ab.Dr["nemzet"]);
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();

            lbSzinesz.Text = "";

            string nemzetek = "SELECT DISTINCT(nemzet) FROM szinesz;";
            Adatbazis ab_nemzet = new Adatbazis(nemzetek);
            cbNemzet.Items.Add("Mind");
            cbNemzet.SelectedIndex = 0;
            while (ab_nemzet.Dr.Read())
            {
                cbNemzet.Items.Add(ab_nemzet.Dr["nemzet"]);
            }
        }

        private void txKereses_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void cbNemzet_SelectedIndexChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void dgAdatok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgAdatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //kiválasztott sor nevének kiírása
            lbSzinesz.Text = dgAdatok.Rows[e.RowIndex].Cells[0].Value.ToString();

            //és a richTextBox-be az összes filmjét kérdezzük le és tegyük bele

            //string sql = "SELECT * FROM film WHERE szinesz.nev = '" + dgAdatok.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
            string sql = "SELECT film.cim, film.megjelenes FROM film JOIN szerepek ON szerepek.filmid = film.filmid JOIN szinesz ON szinesz.szineszid = szerepek.szineszid WHERE szinesz.nev = '" + dgAdatok.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
            Adatbazis ab = new Adatbazis(sql);

            rtxFilmek.Clear();

            while (ab.Dr.Read())
            {
                rtxFilmek.AppendText(ab.Dr["cim"] + ": " + ab.Dr["megjelenes"] + " év\n");
            }

            ab.Close();
        }
    }
}
