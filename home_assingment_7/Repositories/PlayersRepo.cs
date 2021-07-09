using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using home_assingment_7.Models;

namespace home_assingment_7.Repositories
{
    //getting all players from, and adding a new player to the database<br>*
    public class PlayersRepo : IPlayerData
    {
        private readonly home_assignment_7Context _context;
        public PlayersRepo(home_assignment_7Context context)
        {
            _context = context;
        }

        // get all players from the databas
        public List<Player> GetPlayers() => _context.Players.ToList();
        //add a new player to the database
        public void AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            
        }

    }
}
