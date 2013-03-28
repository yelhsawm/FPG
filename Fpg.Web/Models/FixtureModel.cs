using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fpg.Web.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class FixtureModel
    {

        public string HomeTeam1 { get; }

        [Required]
        public string HomeTeamScore1 { get; set; }

        public string AwayTeam1 { get; set;  }

        [Required]
        public string AwayTeamScore1 { get; set; }

    }
}