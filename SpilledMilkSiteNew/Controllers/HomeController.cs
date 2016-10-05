using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SM.Models;

namespace SpilledMilkSiteNew.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			SetTitle("Home");

			return View();
		}

		public ActionResult About()
		{
			SetTitle("About");

			return View();
		}

		public ActionResult Buy()
		{
			SetTitle("Purchase");

			return View();
		}

		public ActionResult Contact()
		{
			SetTitle("Contact");

			return View();
		}

		public ActionResult News()
		{
			SetTitle("News");

			return View();
		}

		public ActionResult Legal()
		{
			SetTitle("Legal");

			return View();
		}

		public ActionResult Origin()
		{
			SetTitle("Origin");

			return View();
		}

		public ActionResult Versions()
		{
			SetTitle("Versions");

			return View();
		}

		private void SetTitle(string title)
		{
			ViewBag.Title = title;
			ViewBag.CompanyName = Constants.COMPANY_NAME;
		}
	}
}