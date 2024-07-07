using System.Web.Optimization;

namespace SpilledMilkSiteNew {
    public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.min.js",
					  "~/Scripts/respond.js"));

			// cbpAnimatedHeader depends on classie to toggle/replace the class.

			bundles.Add(new ScriptBundle("~/bundles/classie").Include("~/Scripts/classie.js"));

			// Adding animated compaction of the navbar

			bundles.Add(new ScriptBundle("~/bundles/cbpAnimatedHeader").Include("~/Scripts/cbpAnimatedHeader.min.js"));

			//bundles.Add(new ScriptBundle("~/bundles/easing").Include("~/Scripts/jquery.easing.1.3.js"));
			//bundles.Add(new ScriptBundle("~/bundles/stellar").Include("~/Scripts/jquery.stellar.js"));
			bundles.Add(new ScriptBundle("~/bundles/wow").Include("~/Scripts/wow.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/nanoGallery").Include("~/Scripts/jquery.nanogallery.min.js"));

			// All the STYLE includes

			bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.min.css", "~/Content/site.css"));
			bundles.Add(new StyleBundle("~/Content/FontAwesome").Include("~/Content/font-awesome.min.css"));

			// http://daneden.github.io/animate.css/
			bundles.Add(new StyleBundle("~/Content/animate").Include("~/Content/animate.css"));

			// http://nanogallery.brisbois.fr
			bundles.Add(new StyleBundle("~/Content/nanoGallery").Include("~/Content/nanogallery.min.css"));

			// Adding the "custom" scripts to a bundle.

			bundles.Add(new ScriptBundle("~/bundles/utilities").Include("~/Scripts/utilities.js"));
		}
	}
}
