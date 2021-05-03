using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    public interface IAuthenticationService
    {
        bool Authenticate(Gamer gamer);
    }
}
