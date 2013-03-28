using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fpg.Core
{
    public class Player
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Alias { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual bool Administrator { get; set; }
        public virtual bool CanUseForum { get; set; }
    }
}
