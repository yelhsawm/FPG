using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fpg.Web.Controllers
{
    using Fpg.Web.Infrastructure;

    [Authorize(Roles = "User")]
    public class FixtureController : Controller
    {
        //
        // GET: /Fixture/

        private FpgDb fpgDb;

        public FixtureController()
        {
            fpgDb = new FpgDb();

        }


        [ValidateAntiForgeryToken]
        public ActionResult FixtureList()
        {
            return View();
        }

        public Action GetFixtures(DateTime fixtureDate)
        {
            



        }









    }
}
