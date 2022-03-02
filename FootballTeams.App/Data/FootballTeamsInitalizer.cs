using FootballTeams.App.Data;
using FootballTeams.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballTeams.App.DataAccess
{
    public class FootballTeamsInitalizer
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FootballTeamsAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FootballTeamsAppContext>>()))
            {
                var players = new List<Player>

            {
            new Player{Name="Carson",SurName="Alexander",DateOfBirth=DateTime.Parse("2005-09-01"), TeamID = 1},
            new Player{Name="Meredith",SurName="Alonso",DateOfBirth=DateTime.Parse("2002-09-01"), TeamID = 1},
            new Player{Name="Arturo",SurName="Anand",DateOfBirth=DateTime.Parse("2003-09-01"),TeamID = 2},
            new Player{Name="Gytis",SurName="Barzdukas",DateOfBirth=DateTime.Parse("2002-09-01"),TeamID = 3},
            new Player{Name="Yan",SurName="Li",DateOfBirth=DateTime.Parse("2002-09-01"),TeamID = 3},
            };

                players.ForEach(s => context.Player.Add(s));
                context.SaveChanges();
                var teams = new List<Team>
            {
            new Team{Name="Milan",City="Milan",Founded=1909, Stadium = "San Siro", History = "test test "},
            new Team{Name="Inter",City="Milan",Founded=1903, Stadium = "Guiseppe Meaza",History = "test test"},
            new Team{Name="Roma",City="Rome",Founded=1902,Stadium = "Rome Stadium", History = "test test "}
            };
                teams.ForEach(s => context.Team.Add(s));
                context.SaveChanges();
            }
        }
    }
}
