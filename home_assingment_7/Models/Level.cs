using System;
using System.Collections.Generic;

#nullable disable

namespace home_assingment_7.Models
{
    public partial class Level
    {
        public Level()
        {
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
