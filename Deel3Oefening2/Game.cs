using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel3Oefening2
{
    class Game
    {
        public string Naam { get; set; }
        public string Genre { get; set; }
        public int Pikorde { get; set; }

        public Game(string naam, string genre, int pikorde)
        {
            Naam = naam;
            Genre = genre;
            Pikorde = pikorde;
        }

        public override string ToString()
        {
            return $"Naam: {Naam}, Genre: {Genre}, Pikorde: {Pikorde}";
        }
    }
}
