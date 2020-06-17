using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Deel3Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHaalOp_Click(object sender, EventArgs e)
        {
            Speler[] spelers = new Speler[]
            {
                new Speler(27, "Cools", "DD", new DateTime(1964, 12, 28), 'V', 1983, "Oudegracht", "10", "1294QK", "Leiden", "010-659599", null, new List<Boete>(){new Boete(3, 27, new DateTime(1983, 9, 10), 100.00m), new Boete(8, 27, new DateTime(1984,11, 12), 75.00m)}),

                new Speler
                {
                        Spelersnr = 44,
                        Naam = "Bakker, de",
                        Voorletters = "E",
                        Geb_Datum = Convert.ToDateTime("1963-01-09"),
                        Geslacht = 'M',
                        Jaartoe = 1980,
                        Straat = "Lawaaistraat",
                        Huisnummer = "23",
                        Postcode = "4444LJ",
                        Plaats = "RijsWijk",
                        Telefoon = "070-368753",
                        Bondsnr = 1124,

                        Boetes = new List<Boete>
                        {
                            new Boete { Betalingsnr = 2, Spelersnr = 44, Bedrag = 75, Datum = Convert.ToDateTime("1981-05-05")},
                            new Boete { Betalingsnr = 5, Spelersnr = 44, Bedrag = 25, Datum = Convert.ToDateTime("1980-12-08")},
                            new Boete { Betalingsnr = 7, Spelersnr = 44, Bedrag = 30, Datum = Convert.ToDateTime("1982-12-30")},
                        }
                }
            };

            var query =
                from speler in spelers
                select new SpelersBoetes
                {
                    AantalBoetes = speler.Boetes.Count,
                    SpelersNr = speler.Spelersnr,
                    SpelersNaam = speler.Naam,
                    SpelersHuisNr = speler.Huisnummer,
                    SpelersVoorletters = speler.Voorletters,
                    SpelersStraat = speler.Straat,
                    SpelersPostcode = speler.Postcode,
                    SpelersPlaats = speler.Plaats,
                };

            foreach (var speler in query)
            {
                textBoxResultaat.AppendText(speler + Environment.NewLine);
            }
        }
    }
}
