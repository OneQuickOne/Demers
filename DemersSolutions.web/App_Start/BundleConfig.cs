using System.Web;
using System.Web.Optimization;

namespace DemersSolutions.web {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/Openmind/jquery.cookie.js",
                "~/Scripts/Openmind/bootstrap.min.js",
                "~/Scripts/Openmind/jquery.mixitup.min.js",
                "~/Scripts/Openmind/lightbox-2.6.min.js",
                "~/Scripts/Openmind/holder.js",
                "~/Scripts/Openmind/app.js",
                //"~/Scripts/Openmind/styleswitcher.js",
                "~/Scripts/Openmind/syntax/shCore.js",
                "~/Scripts/Openmind/syntax/shBrushXml.js",
                "~/Scripts/Openmind/syntax/shBrushJScript.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Themes/Openmind/css/bootstrap.min.css",
                "~/Content/Themes/Openmind/css/font-awesome.min.css",
                "~/Content/Themes/Openmind/css/animate.min.css",
                "~/Content/Themes/Openmind/css/lightbox.css",
                "~/Content/Themes/Openmind/css/syntax/shCore.css",
                "~/Content/Themes/Openmind/css/syntax/shThemeDefault.css"
                //"~/Content/Themes/Openmind/css/style.css",
                //"~/Content/Themes/Openmind/css/color-default.css",
                //"~/Content/Themes/Openmind/css/width-full.css"
                ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            // BundleTable.EnableOptimizations = true;
        }
    }
}
