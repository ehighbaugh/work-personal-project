using System.Web;
using System.Web.Optimization;

namespace Work_Personal_Project
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        "~/Scripts/custom/*.js"));        

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/gatag").Include(
                "~/Scripts/Custom/GATag.js"));

            bundles.Add(new ScriptBundle("~/bundles/resHelper").Include(
                "~/Scripts/Custom/ResTracker.js"));

            bundles.Add(new StyleBundle("~/bundles/customcss").Include(
                      "~/Content/css/fontawesome/*.css",
                      "~/Content/css/bootstrap/*.css",
                      "~/Content/css/webfonts/*.css",
                      "~/Content/css/custom/*.css"));

            bundles.Add(new StyleBundle("~/bundles/fab", "https://use.fontawesome.com/releases/v5.3.1/css/brands.css").Include("~/Content/css/fontawesome/brands.css"));
            bundles.Add(new StyleBundle("~/bundles/fa", "https://use.fontawesome.com/releases/v5.3.1/css/fontawesome.css").Include("~/Content/fontawesome.css"));

            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
        }
    }
}
