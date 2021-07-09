using System;
using System.Collections.Generic;

#nullable disable

namespace home_assingment_7.Models
{
    public partial class Levels
    {
        public Levels()
        {
            Scores = new HashSet<Scores>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Scores> Scores { get; set; }
    }
}
