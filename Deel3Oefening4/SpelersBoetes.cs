using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel3Oefening4
{
    class SpelersBoetes
    {
        public int AantalBoetes { get; set; }

        public int SpelersNr { get; set; }

        public string SpelersNaam { get; set; }

        public string SpelersVoorletters { get; set; }

        public string SpelersStraat { get; set; }

        public string SpelersHuisNr { get; set; }

        public string SpelersPostcode { get; set; }

        public string SpelersPlaats { get; set; }

        public SpelersBoetes()
        {

        }

        public override string ToString()
        {
            return $"{SpelersNaam} - {AantalBoetes}";
        }
    }
}
