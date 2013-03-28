using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fpg.Core
{
    public class Fixture
    {
        public virtual int Id { get; set; }
        public virtual string HomeTeam { get; set; }
        public virtual string AwayTeam { get; set; }
        public ICollection<Fixture> Fixtures { get; set; }
    }
}
