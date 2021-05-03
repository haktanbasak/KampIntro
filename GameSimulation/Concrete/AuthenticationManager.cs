using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class AuthenticationManager : IAuthenticationService
    {
        public bool Authenticate(Gamer gamer)
        {
            return true;
        }
    }
}
