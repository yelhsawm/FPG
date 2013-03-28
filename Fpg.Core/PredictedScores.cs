using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fpg.Core
{
    public class PredictedScore
    {
        public virtual int Id { get; set; }
        public virtual string HomeScore { get; set; }
        public virtual string AwayScore { get; set; }
        public ICollection<PredictedScore> PredictedScores { get; set; }
    }
}
