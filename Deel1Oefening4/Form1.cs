using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Deel1Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZoek_Click(object sender, EventArgs e)
        {
            textBoxResultaat.Clear();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ZoekOpNaam", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("Voornaam", $"%{textBoxVoornaam.Text}%");
                cmd.Parameters.AddWithValue("Achternaam", $"%{textBoxAchternaam.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();
                int teller = 1;
                while (reader.Read())
                {
                    textBoxResultaat.AppendText($"{teller++}\t{reader.GetString(0)} {reader.GetString(1)}{Environment.NewLine}");
                }
            }
        }
    }
}
