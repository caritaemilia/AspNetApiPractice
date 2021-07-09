using System;
using System.Collections.Generic;

#nullable disable

namespace home_assingment_7.Models
{
    public partial class Player
    {
        public Player()
        {
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public int CountryCode { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
