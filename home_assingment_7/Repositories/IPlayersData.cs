using home_assingment_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home_assingment_7.Repositories
{
    public interface IPlayersData
    {
        List<Players> GetPlayers();
        void AddPlayer(Players player);
    }
}
