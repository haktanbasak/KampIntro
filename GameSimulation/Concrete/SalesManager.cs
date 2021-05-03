using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    class SalesManager : ISalesService
    {
        public void SalesGame(Gamer gamer, Game game, Campaign campaign)
        {
            double price;
            if (campaign.CampaignDiscount != 0)
            {
                price = game.GamePrice - (game.GamePrice * campaign.CampaignDiscount / 100);
            }
            else
            {
                price = game.GamePrice;
            }

            Console.WriteLine("'{0}' oyunu '{1}' a '{2}' kampanyası ile '{3}' TL karşılığında satıldı.",game.GameName,gamer.Name, campaign.CampaignName,price);
        }
    }
}
