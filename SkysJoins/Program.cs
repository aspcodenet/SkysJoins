using System;
using System.Collections.Generic;
using System.Linq;

namespace SkysJoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teams = new[]
            {
                new Team{Id=1, Name="Sweden", Manager="Curt Lundmark"},
                new Team{Id=2, Name="Russia", Manager="Viktor Tichonov"},
                new Team{Id=3, Name="Canada", Manager = "Barry Smith"},
            };
            var players = new []
            {
                new Player{Id=1,Jersey=13, Name="Mats Sundin",TeamId = 1},
                new Player{Id=2,Jersey=8, Name="Alexander Ovetskin",TeamId = 2},
                new Player{Id=3,Jersey=21, Name="Peter Forsberg",TeamId = 1},
            };

            //Lista alla spelare! Och deras lag namn också
            foreach (var player in players)
            {
                var teamid = player.TeamId;
                var team = teams.FirstOrDefault(t => t.Id == teamid);
                Console.WriteLine($"{player.Name} {team.Name}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
