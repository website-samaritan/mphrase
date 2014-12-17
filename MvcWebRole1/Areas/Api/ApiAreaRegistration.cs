using System.Web.Mvc;

namespace MvcWebRole1.Areas.Api
{
	public class ApiAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Api";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{

			// TODO: Values controller isn't being routed to.
			context.MapRoute(
				"Api_default",
				"Api/{controller}/{action}/{id}",
				new { action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
