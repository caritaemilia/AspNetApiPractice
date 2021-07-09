using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using home_assingment_7.Models;

namespace home_assingment_7.Repositories
{
    // getting all levels from, and adding a new level to the database<br>
    public class LevelsRepo : ILevelData
    {
        //ínjecting the dbcontext to repo

        private readonly home_assignment_7Context _context;
        
        public LevelsRepo(home_assignment_7Context context)
        {
            _context = context;
        }

        //get all levels from the database
        public List<Level> GetLevels() => _context.Levels.ToList();
     
        //add a new level to the database
        public void AddLevel(Level level)
        {

            _context.Levels.Add(level);
            _context.SaveChanges();
           
        }

    }
}

