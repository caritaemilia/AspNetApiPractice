using home_assingment_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home_assingment_7.Repositories
{/*-  getting all scores from, adding a new score to, and deleting a score from the database<br>
-  getting all levels from, and adding a new level to the database<br>
-*/
    public class ScoresRepo : IScoreData
    {

        private readonly home_assignment_7Context _context;

        public ScoresRepo(home_assignment_7Context context)
        {
            _context = context;
        }

        //read operation for scores first by id second for all

        public List<Score> GetScores() => _context.Scores.ToList();
        public Score GetScore(int id)
        {
            return _context.Scores.FirstOrDefault(s => s.Id == id);
        }

        //add a new score to db
        public void AddScore(Score score)
        {
            _context.Scores.Add(score);
            _context.SaveChanges();
        
        }

        public void DeleteScore(Score score)
        {
            _context.Scores.Remove(score);
        }
    }
}
