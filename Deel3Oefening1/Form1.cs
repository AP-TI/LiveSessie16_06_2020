using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deel3Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValideer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxInput.Text.IsEAN13BarcodeValid() ? "Geldig!" : "Ongeldig!");
        }
    }
}
