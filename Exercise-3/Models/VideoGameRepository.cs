using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Models
{
    internal class VideoGameRepository
    {
        public HashSet<VideoGame> VideoGames { get; set; } = new();
        public HashSet<VideoGameConsole> Consoles { get; set; } = new();
        public HashSet<Publisher> Publishers { get; set; } = new();
        public HashSet<Studio> Studios { get; set; } = new();

        public VideoGameRepository()
        {
            Studio coffeeStainStudio = new("Coffee Stain Studios", 1_000_000);
            Studio maddyMakesGamesStudio = new("Maddy Makes Games", 3_000_000);

            Studios.Add(maddyMakesGamesStudio);
            Studio monolithSoft = new("Monolith Soft", 1_000_000);
            Studio halLabs = new("HAL Laboratories", 1_000_000);

            Studios.Add(coffeeStainStudio);
            Studios.Add(monolithSoft);
            Studios.Add(halLabs);

            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);

            Publisher maddyMakesGamesPublishing = new("Maddy Makes Games", 36_000_000);
            Publishers.Add(coffeeStainPublishing);
            Publishers.Add(maddyMakesGamesPublishing);

            Publisher nintendo = new("Nintendo", 100_000_000);
            Publishers.Add(nintendo);

            //Zack added
            Publisher FiveOFive = new("505 Games", 5_000_000);
            Publishers.Add(FiveOFive);
            //Zack added
            Studio Kunos = new("Kunos Simulazioni", 25_000_000);
            Studios.Add(Kunos);

            VideoGameConsole pc = new("PC", 1500, 20, true);
            VideoGameConsole wiiU = new("Wii U", 400, 8, true);
            VideoGameConsole nSwitch = new("Switch", 400, 8, true);

            Consoles.Add(pc);
            Consoles.Add(wiiU);
            Consoles.Add(nSwitch);

            VideoGame satisfactory = new(
                title: "Satisfactory",
                category: "Simulation",
                year: 2018,
                playerCount: 4,
                price: 40f,
                studio: coffeeStainStudio,
                consoles: new() { pc },
                publisher: coffeeStainPublishing,
                ageRating: 10

                );

            VideoGame celeste = new(
                title: "Celeste",
                category: "Platformer",
                year: 2018,
                playerCount: 1,
                price: 20f,
                studio: maddyMakesGamesStudio,
                consoles: new() { pc },
                publisher: maddyMakesGamesPublishing,
                ageRating: 10
                );
            //Zack Added
            VideoGame ACC = new(
               title: "Assetto Corsa Competionze",
               category: "Sim Racing",
               year: 2019,
               playerCount: 40,
               price: 50f,
               studio: Kunos,
               consoles: new() { pc },
               publisher: FiveOFive,
               ageRating: 18
           );
            //Zack Added
            VideoGame ACUlt = new(
                title: "Assetto Corsa Ultimate Edition",
                category: "Sim Racing",
                year: 2014,
                playerCount: 100,
                price: 90f,
                studio: Kunos,
                consoles: new() { pc },
                publisher: FiveOFive,
                ageRating: 18
            );
            VideoGames.Add(satisfactory);
            VideoGames.Add(celeste);
            VideoGames.Add(ACC);
            VideoGames.Add(ACUlt);

            coffeeStainStudio.AddGame(satisfactory);
            coffeeStainPublishing.AddStudio(coffeeStainStudio);

            Studio hopooGames = new("Hopoo Games", 5_000_000);
            Studios.Add(hopooGames);

            Publisher gearbox = new("Gearbox", 5);
            Publishers.Add(gearbox);

            VideoGame riskOfRain = new(
                title: "Risk of Rain",
                category: "Roguelike",
                year: 2013,
                playerCount: 4,
                price: 11f,
                studio: hopooGames,
                consoles: new() { pc },
                publisher: gearbox,
                ageRating: 13
                );
            VideoGames.Add(riskOfRain);

            hopooGames.AddGame(riskOfRain);
            gearbox.AddStudio(hopooGames);
            pc.AddGame(riskOfRain);

            VideoGame riskOfRain2 = new(
                title: "Risk of Rain 2",
                category: "Roguelike",
                year: 2018,
                playerCount: 4,
                price: 29f,
                studio: hopooGames,
                consoles: new() { pc },
                publisher: gearbox,
                ageRating: 13
                );
            VideoGames.Add(riskOfRain2);

            hopooGames.AddGame(riskOfRain2);
            pc.AddGame(riskOfRain2);

            Studio ninjaKiwi = new("Ninja Kiwi", 3_000_000);
            Studios.Add(ninjaKiwi);

            Publisher ninjaKiwiPublishing = new("Ninja Kiwi Publishing", 1_000_000);
            Publishers.Add(ninjaKiwiPublishing);

            VideoGame bloonsTD6 = new(
                title: "Bloons TD 6",
                category: "Tower Defense",
                year: 2018,
                playerCount: 4,
                price: 15.49f,
                studio: ninjaKiwi,
                consoles: new() { pc },
                publisher: ninjaKiwiPublishing,
                ageRating: 9
                );
            VideoGames.Add(bloonsTD6);

            ninjaKiwi.AddGame(bloonsTD6);
            ninjaKiwiPublishing.AddStudio(ninjaKiwi);
            pc.AddGame(bloonsTD6);

            maddyMakesGamesStudio.AddGame(celeste);
            maddyMakesGamesPublishing.AddStudio(maddyMakesGamesStudio);

            VideoGame xenoblade = new(
                title: "Xenoblade Chronicles: Definitive Edition",
                category: "JRPG",
                year: 2020,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade2 = new(
                title: "Xenoblade Chronicles 2",
                category: "JRPG",
                year: 2017,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade3 = new(
                title: "Xenoblade Chronicles 3",
                category: "JRPG",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenobladeX = new(
                title: "Xenoblade Chronicles X",
                category: "JRPG",
                year: 2015,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { wiiU },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame forgottenLand = new(
                title: "Kirby and the Forgotten Land",
                category: "3D Platformer",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: halLabs,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 7
            );

            VideoGames.Add(xenoblade);
            VideoGames.Add(xenoblade2);
            VideoGames.Add(xenoblade3);
            VideoGames.Add(xenobladeX);
            VideoGames.Add(forgottenLand);

            monolithSoft.AddGame(xenoblade);
            monolithSoft.AddGame(xenoblade2);
            monolithSoft.AddGame(xenoblade3);
            monolithSoft.AddGame(xenobladeX);

            halLabs.AddGame(forgottenLand);

            nSwitch.AddGame(xenoblade);
            nSwitch.AddGame(xenoblade2);
            nSwitch.AddGame(xenoblade3);
            nSwitch.AddGame(forgottenLand);

            wiiU.AddGame(xenobladeX);

            pc.AddGame(satisfactory);
            pc.AddGame(celeste);
        }
    }
}
