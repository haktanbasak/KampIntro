using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entities
{
    public class Sales
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int GamerId { get; set; }
        public int CampaignId { get; set; }

        public DateTime SaleDate { get; set; }

        public double Price { get; set; }
    }
}
