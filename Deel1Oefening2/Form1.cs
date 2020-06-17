using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deel1Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHaalOp_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Person.Person;", conn);
                textBoxResultaat.Text = cmd.ExecuteScalar().ToString();
            }
        }

        private void buttonEersteHonderd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Top(100) FirstName, LastName FROM Person.Person;", conn);
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
