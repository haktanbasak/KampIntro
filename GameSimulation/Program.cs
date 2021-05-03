using GameSimulation.Adapter;
using GameSimulation.Concrete;
using GameSimulation.Entities;
using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Id = 1, GameName = "Call of Duty", GamePrice = 100.00 };
            Game game2 = new Game() { Id = 2, GameName = "Battlefield", GamePrice = 80.00 };
            Game game3 = new Game() { Id = 3, GameName = "Medal of Honor", GamePrice = 50.00 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game3);

            Console.WriteLine("--------------------------------------------------------------------------------");

            Gamer gamer1 = new Gamer() { NationalityId = "1212211212121", Name = "Haktan", Surname = "Başak", DateOfBirth = new DateTime(1996,12,1) };
            Gamer gamer2 = new Gamer() { NationalityId = "4212214322121", Name = "Mustafa", Surname = "Özdoğan", DateOfBirth = new DateTime(1997,12,1) };

            GamerManager gamerManager = new GamerManager(new AuthenticationManager());
            gamerManager.Add(gamer1);
            GamerManager gamerManager1 = new GamerManager(new MernisAdapter());
            gamerManager1.Add(gamer2);

            Console.WriteLine("--------------------------------------------------------------------------------");

            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "Büyük Bahar",
                CampaignDiscount = 30
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            Console.WriteLine();
            Console.WriteLine("------------------------- S A T I Ş ----------------------------");
            Console.WriteLine();

            SalesManager salesManager = new SalesManager();
            salesManager.SalesGame(gamer1, game1, campaign);

        }
    }
}
