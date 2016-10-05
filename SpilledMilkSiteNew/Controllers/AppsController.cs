using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SM.Models;

namespace SpilledMilkSiteNew.Controllers
{
    public class AppsController : Controller
    {
		public ActionResult CheckOutMyStuff()
		{
			SetTitle("Check Out My Stuff");

			return View();
		}

        public ActionResult IdiotDriver()
        {
			SetTitle("Idiot Driver");

            return View();
        }

		public ActionResult Index()
		{
			SetTitle("Applications");

			return View();
		}

		private void SetTitle(string title)
		{
			ViewBag.Title = title;
			ViewBag.CompanyName = Constants.COMPANY_NAME;
		}
	}
}