using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FootballTeams.App.Models;

namespace FootballTeams.App.Data
{
    public class FootballTeamsAppContext : DbContext
    {
        public FootballTeamsAppContext (DbContextOptions<FootballTeamsAppContext> options)
            : base(options)
        {
        }
        public FootballTeamsAppContext()
            : base()
        {

        }

        public DbSet<FootballTeams.App.Models.Player> Player { get; set; }

        public DbSet<FootballTeams.App.Models.Team> Team { get; set; }
    }
}
