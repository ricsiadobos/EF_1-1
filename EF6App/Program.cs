using EF6.Data;
using EF6.Domain;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF6
{
    class Program
    {
        private static FootballLeagueDbContext context = new FootballLeagueDbContext();
        static async Task Main(string[] args)
        { 
            var teams = context.Teams.ToList();
            var CsakABayern = teams.Where(x=>x.Name.Contains("Bay")).ToList();
            var NameSubstring =  teams.Select(x => x.Name.Substring(0,3)).ToList();
            var legues = context.Leagues.Where(x => x.Name.Contains("a")).ToList();
            var legueWhereE = context.Leagues.Select(csapat => csapat).Where(csapat => csapat.Name.Contains("e")).ToList();

         
            
            // Tömb, azonos elem kiszortírozása
            var elemek = new string[] { "bati", "tomi", "bati", "mano" };
            List<string> valogatott = new List<string>();
            for (int i = 0; i < elemek.Count(); i++)
            {
                if (!valogatott.Contains(elemek[i]))
                {
                    valogatott.Add(elemek[i]);
                }    
            }


            Console.ReadLine();

        }

      
    }
}
