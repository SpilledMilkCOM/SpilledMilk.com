using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SpilledMilkSiteNew
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
			//throw new Exception("Application_Start() was called!");

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        /// NOTE: https://forums.asp.net/t/1505777.aspx?Error+Handling+in+global+asax
        /// </summary>
        protected void Application_Error()
        {
            var context = HttpContext.Current;
            var lastError = context.Server.GetLastError();
            var error = new KeyValuePair<string, object>("ErrorMessage", lastError.Message);
            var stack = new KeyValuePair<string, object>("StackTrace", lastError.StackTrace);

            context.Response.Clear();

            RequestContext rc = ((MvcHandler)context.CurrentHandler).RequestContext;
            string controllerName = rc.RouteData.GetRequiredString("controller");
            IControllerFactory factory = ControllerBuilder.Current.GetControllerFactory();
            IController controller = factory.CreateController(rc, controllerName);
            ControllerContext cc = new ControllerContext(rc, (ControllerBase)controller);

            ViewResult viewResult = new ViewResult { ViewName = "Error" };
            viewResult.ViewData.Add(error);
            viewResult.ExecuteResult(cc);
            context.Server.ClearError();
            //ctx.Response.End();
        }
    }
}