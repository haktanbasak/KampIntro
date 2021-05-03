using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    public interface ISalesService
    {
        void SalesGame(Gamer gamer, Game game, Campaign campaign);
    }
}
