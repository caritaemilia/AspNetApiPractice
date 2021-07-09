using home_assingment_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home_assingment_7.Repositories
{
    public class ScoresRepo : IScoresData
    {

        private readonly home_assignment_7Context _context;

        public ScoresRepo(home_assignment_7Context context)
        {
            _context = context;
        }

        public List<Scores> GetScores() => _context.Scores.ToList();
        public Scores GetScore(int id)
        {
            return _context.Scores.FirstOrDefault(s => s.Id == id);
        }


        public void AddScore(Scores score)
        {
            _context.Scores.Add(score);
            _context.SaveChanges();
        
        }

        public void DeleteScore(Scores score)
        {
            _context.Scores.Remove(score);
        }
    }
}
