using System;
using System.Collections.Generic;

namespace Deel3Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            var gebruiker =
            new
            {
                Naam = "Maxim",
                Achternaam = "Janssens",
                Games = new List<Game>()
            {
                new Game("Eurotruck Simulator 2", "Simulatie", 1),
                new Game("Fortnite", "Battle Royale", 2),
                new Game("Valorant", "CSGO", 3),
            },
            };

            Console.WriteLine($"Hallo, ik ben {gebruiker.Naam} {gebruiker.Achternaam} en mijn favoriete games zijn:");
            gebruiker.Games.ForEach(Console.WriteLine);
        }
    }
}
