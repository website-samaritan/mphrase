using System.Web;
using System.Web.Optimization;

namespace mphraseWebRole
{
	public class BundleConfig
	{
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/css")
				            .Include("~/css/normalize.css")
				            .Include("~/css/foundation.css")
				            .Include("~/css/site.css"));
		}
	}
}