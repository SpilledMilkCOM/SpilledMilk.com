using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SM.Models;

namespace SpilledMilkSiteNew.Controllers
{
    public class CiCiController : Controller
    {
        public ActionResult Characters()
        {
			SetTitle("Characters");

            return View();
        }
		public ActionResult Credits()
		{
			SetTitle("Credits");

			return View();
		}

		public ActionResult Index()
		{
			SetTitle("CiCi Miniseries");

			return View();
		}

		public ActionResult Story()
		{
			SetTitle("Story");

			return View();
		}

		private void SetTitle(string title)
		{
			ViewBag.Title = title;
			ViewBag.CompanyName = Constants.COMPANY_NAME;
		}
	}
}