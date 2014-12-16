using System.Web.Mvc;

namespace MvcWebRole1.Areas.PublicFace
{
	public class PublicFaceAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "PublicFace";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
				"Public Face Default",
				"{controller}/{action}/{id}",
				new { area = "PublicFace", controler="Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
