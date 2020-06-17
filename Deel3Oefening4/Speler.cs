using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel3Oefening4
{
    class Speler
    {
        public int Spelersnr { get; set; }
        public string Naam { get; set; }
        public string Voorletters { get; set; }
        public DateTime Geb_Datum { get; set; }
        public char? Geslacht { get; set; }
        public int Jaartoe { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Telefoon { get; set; }
        public int? Bondsnr { get; set; }
        public List<Boete> Boetes { get; set; }

        public Speler()
        {

        }

        public Speler(int spelersnr, string naam, string voorletters, DateTime geb_Datum, char? geslacht, int jaartoe, string straat, string huisnummer, string postcode, string plaats, string telefoon, int? bondsnr, List<Boete> boetes)
        {
            Spelersnr = spelersnr;
            Naam = naam;
            Voorletters = voorletters;
            Geb_Datum = geb_Datum;
            Geslacht = geslacht;
            Jaartoe = jaartoe;
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Plaats = plaats;
            Telefoon = telefoon;
            Bondsnr = bondsnr;
            Boetes = boetes;
        }
    }
}
