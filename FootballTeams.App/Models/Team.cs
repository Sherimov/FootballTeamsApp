using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootballTeams.App.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public int Founded { get; set; }
        public string History { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
