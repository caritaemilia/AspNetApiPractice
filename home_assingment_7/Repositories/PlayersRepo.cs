using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using home_assingment_7.Models;

namespace home_assingment_7.Repositories
{
    public class PlayersRepo : IPlayersData
    {
        private readonly home_assignment_7Context _context;
        public PlayersRepo(home_assignment_7Context context)
        {
            _context = context;
        }

        public List<Players> GetPlayers() => _context.Players.ToList();

        public void AddPlayer(Players player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            
        }

    }
}
