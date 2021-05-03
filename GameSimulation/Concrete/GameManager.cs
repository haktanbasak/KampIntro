using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Oyun Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Oyun Silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Oyun Güncellendi.");
        }
    }
}
