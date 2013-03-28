using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fpg.Core
{
    public interface IFpgDataSource
    {
        IQueryable<Fixture> Fixtures { get; }
        IQueryable<Player> Players { get; }
        IQueryable<List<PredictedScore>> PredictedScores { get; }
        IQueryable<List<ActualScore>> ActualScores { get; }

        void Save();
    }
}
