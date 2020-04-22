using System.Web;
using System.Web.Optimization;

namespace Mvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template designe

            bundles.Add(new ScriptBundle("~/template/js").Include(
                      "~/Scripts/modernizr.js",
                       "~/Scripts/all.js",
                        "~/Scripts/jquery.mobile.customized.min.js",
                         "~/Scripts/jquery.easing.1.3.js",
                          "~/Scripts/parallaxie.js",
                           "~/Scripts/headline.js",
                            "~/Scripts/jqBootstrapValidation.js",
                             "~/Scripts/contact_me.js",
                              "~/Scripts/custom.js",
                               "~/Scripts/jquery.vide.js"
                      ));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/css/bootstrap.min.css",
                       "~/Content/css/style.css",
                        "~/Content/css/responsive.css",
                         "~/Content/css/custom.css"));

            #endregion
        }
    }
}
