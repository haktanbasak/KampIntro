using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
