using System;
using System.Collections.Generic;

#nullable disable

namespace home_assingment_7.Models
{
    public partial class Score
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int TimeInSeconds { get; set; }
        public int HighScore { get; set; }
        public int PlayerId { get; set; }
        public int LevelId { get; set; }

        public virtual Level Level { get; set; }
        public virtual Player Player { get; set; }
    }
}
