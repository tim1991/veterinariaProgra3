using System.Web;
using System.Web.Optimization;

namespace SitioWeb
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
       

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/app.css"));
        }
    }
}
