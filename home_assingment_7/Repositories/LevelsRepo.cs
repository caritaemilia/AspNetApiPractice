using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using home_assingment_7.Models;

namespace home_assingment_7.Repositories
{
 
    public class LevelsRepo : ILevelsData
    {


        private readonly home_assignment_7Context _context;
        
        public LevelsRepo(home_assignment_7Context context)
        {
            _context = context;
        }


        public List<Levels> GetLevels() => _context.Levels.ToList();
     

        public void AddLevel(Levels level)
        {

            _context.Levels.Add(level);
            _context.SaveChanges();
           
        }

    }
}

