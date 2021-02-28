using System.Web;
using System.Web.Optimization;
namespace tiket_reservation
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
            "~/Scripts/jquery.js",
            "~/Scripts/bootstrap.js",
            "~/Scripts/jquery.fullpage.js",
            "~/Scripts/material.js",
            "~/Scripts/ripples.js"
            ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
            "~/Content/css/style.css",
            "~/Content/css/bootstrap.css",
            "~/Content/css/bootstrap-material-design.css",
            "~/Content/css/jquery.fullpage.css",
            "~/Content/css/ripples.css",
            "~/Content/css/font-awesome/font-awesome.css"
            ));
        }
    }
}