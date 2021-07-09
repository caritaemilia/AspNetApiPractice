using home_assingment_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home_assingment_7.Repositories
{
   public interface ILevelData
    {
        List<Level> GetLevels();

        void AddLevel(Level level);



    }
}
