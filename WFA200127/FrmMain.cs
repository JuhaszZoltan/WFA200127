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
using System.IO;
using System.Reflection;

namespace WFA200127
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        public FrmMain()
        {
            AppDomain.CurrentDomain.SetData(
                "DataDirectory",
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly()
                    .Location)
                .Replace(@"bin\Debug", "Data"));

            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                @"AttachDbFilename=|DataDirectory|osztalypenztar2000.mdf;");
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT nev, SUM(osszeg) FROM naplo INNER JOIN bank " +
                "ON naplo.sorszam = ki " +
                "WHERE nev NOT LIKE 'osztály fonök' " +
                "GROUP BY nev ORDER BY nev;", conn);

            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgvOsszesito.Rows.Add(r[0], r[1]);
            }
            cmd = new SqlCommand(
                "SELECT SUM(osszeg) FROM bank " +
                "WHERE leiras LIKE '%fenymasolas%';", conn);
            r.Close();
            r = cmd.ExecuteReader();
            r.Read();
            tbFenymasolasraOsszesen.Text = r.GetInt32(0) * -1 + " Ft";
            r.Close();
            cmd = new SqlCommand(
                "SELECT nev FROM naplo " +
                "WHERE nev NOT LIKE 'osztály fonök';",
                conn);
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbDiakok.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void cbDiakok_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbDiakTranzakcioi.Clear();
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT mikor, leiras, osszeg FROM bank " +
                "WHERE ki = (SELECT sorszam FROM naplo " +
                $"WHERE nev LIKE '{cbDiakok.SelectedItem.ToString()}');",
                conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                rtbDiakTranzakcioi.Text +=
                    r.GetDateTime(0).ToString("yyyy-MM-dd") + "\n" +
                    r[1] + "\n" +
                    r[2] + "Ft\n\n";
            }
            conn.Close();
        }
    }
}
