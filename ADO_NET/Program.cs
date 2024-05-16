using System;
using System.Collections.Generic;
using System.Linq;
using ADO_NET_6.Models;
using ADO_NET_6.Data;

namespace ADO_NET_6.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FootballContext())
            {
               
                context.Database.EnsureCreated();

                
                var teams = new List<Team>
                {
                    new Team { Name = "Real Madrid", City = "Madrid", Wins = 20, Losses = 5, Draws = 3 },
                    new Team { Name = "Barcelona", City = "Barcelona", Wins = 18, Losses = 7, Draws = 3 },
                    new Team { Name = "Atletico Madrid", City = "Madrid", Wins = 16, Losses = 6, Draws = 6 }
                };
                context.Teams.AddRange(teams);
                context.SaveChanges();

                
                var allTeams = context.Teams.ToList();
                foreach (var team in allTeams)
                {
                    Console.WriteLine($"Name: {team.Name}, City: {team.City}, Wins: {team.Wins}, Losses: {team.Losses}, Draws: {team.Draws}");
                }
            }
        }
    }
}
