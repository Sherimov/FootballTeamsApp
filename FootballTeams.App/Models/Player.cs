using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballTeams.App.Models
{
    public class Player
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MarketValue { get; set; }
        public int TeamID { get; set; }
    }
}
