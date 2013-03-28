using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fpg.Web.Infrastructure
{
    using System.Data.Entity;

    using Fpg.Core;

    public class FpgDb : DbContext, IFpgDataSource
    {

        public FpgDb() : base("FpgDb")
        {
        }

        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PredictedScore> PredictedScores { get; set; }
        public DbSet<ActualScore> ActualScores { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }


        IQueryable<Fixture> IFpgDataSource.Fixtures
        {
            get
            {
                return Fixtures;
            }
        }

        IQueryable<Player> IFpgDataSource.Players
        {
            get
            {
                return Players;
            }
        }

        IQueryable<List<PredictedScore>> IFpgDataSource.PredictedScores
        {
            get
            {
                return new NotImplementedException();
            }
        }

        IQueryable<List<ActualScore>> IFpgDataSource.ActualScores
        {
            get
            {
                return ActualScores;
            }
        }
    }
}