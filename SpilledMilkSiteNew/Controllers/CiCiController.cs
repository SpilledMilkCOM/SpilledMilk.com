using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SM.Models;
using SM.Utils;

namespace SpilledMilkSiteNew.Controllers
{
    public class CiCiController : Controller
    {
        public ActionResult Characters()
        {
			SetTitle(nameof(Characters));

            return View();
        }

		public ActionResult CoverSketches()
		{
			SetTitle("Cover Sketches");

			return View();
		}

        public ActionResult CreditParker()
        {
            SetTitle("Parker Smart");

            return View();
        }

        public ActionResult Credits()
		{
			SetTitle(nameof(Credits));

			return View();
		}

		public ActionResult Images()
		{
			SetTitle(nameof(Images));

			return View();
		}

		public ActionResult Index()
		{
			SetTitle(null);

			return View();
		}

		public ActionResult Pinups()
		{
			SetTitle(nameof(Pinups));

			return View();
		}

		public ActionResult Story()
		{
			SetTitle(nameof(Story));

			return View();
		}

		private void SetTitle(string title)
		{
            ControllerUtil.SetSubtitle(ViewBag, title, "CiCi Miniseries");
		}
	}
}