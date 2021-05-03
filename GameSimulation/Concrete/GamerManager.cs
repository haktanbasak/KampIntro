using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    class GamerManager : IGamerService
    {
        private IAuthenticationService _authenticationService;

        public GamerManager(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public void Add(Gamer gamer)
        {
            if (_authenticationService.Authenticate(gamer))
            {
                Console.WriteLine("Kişi doğrulandı. '{0}' eklendi", gamer.Name);
            }
            else
            {
                Console.WriteLine("Kişi doğrulanmadı. '{0}' eklenemedi", gamer.Surname);
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Surname + " Oyuncu güncellendi");
        }
    }
}
