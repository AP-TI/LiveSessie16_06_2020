using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel3Oefening4
{
    class Boete
    {
        public int Betalingsnr { get; set; }
        public int Spelersnr { get; set; }
        public DateTime Datum { get; set; }
        public decimal Bedrag { get; set; }

        public Boete()
        {

        }

        public Boete(int betalingsnr, int spelersnr, DateTime datum, decimal bedrag)
        {
            Betalingsnr = betalingsnr;
            Spelersnr = spelersnr;
            Datum = datum;
            Bedrag = bedrag;
        }
    }
}
