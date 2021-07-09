using home_assingment_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home_assingment_7.Repositories
{
    public interface IScoresData
    {
        List<Scores> GetScores();

        Scores GetScore(int id);

        void AddScore(Scores score);

        void DeleteScore(Scores score);

    }
}
