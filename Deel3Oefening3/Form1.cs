using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Deel3Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            textBoxResultaat.Clear();
            int bovengrens = int.Parse(textBoxBovengrens.Text);
            int ondergrens = int.Parse(textBoxOndergens.Text);
            int[] getallen = new int[bovengrens + 1 - ondergrens];

            for (int i = 0; i < getallen.Length; i++)
                getallen[i] = i + ondergrens;


            IEnumerable<int> even = from getal in getallen where getal % 2 == 0 select getal;

            foreach (int getal in even)
                textBoxResultaat.AppendText(getal + Environment.NewLine);
        }

        private void buttonGoString_Click(object sender, EventArgs e)
        {
            textBoxResultaatString.Clear();
            string scheidingsteken = textBoxScheidingsteken.Text;
            string namenReeks = textBoxNamenReeks.Text;
            string filter = textBoxZoek.Text.ToLower();

            string[] reeks = namenReeks.Split(char.Parse(scheidingsteken));
            IEnumerable<string> gefilterd;
            if (radioButtonBegintMet.Checked)
            {
                gefilterd = from naam in reeks where naam.ToLower().StartsWith(filter) select naam;
            }
            else if (radioButtonEindigtMet.Checked)
            {
                gefilterd = from naam in reeks where naam.ToLower().EndsWith(filter) select naam;
            }
            else
            {
                gefilterd = from naam in reeks where naam.ToLower().Contains(filter) select naam;
            }

            foreach (string naam in gefilterd)
                textBoxResultaatString.AppendText(naam + Environment.NewLine);
        }
    }
}
