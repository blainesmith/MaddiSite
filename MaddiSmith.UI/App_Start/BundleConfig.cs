using System.Web.Optimization;

namespace MaddiSmith.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                "~/Scripts/JQuery/jquery-{version}.js",
                "~/Scripts/Bootstrap/bootstrap.js",
                "~/Scripts/AngularJS/angular.js",
                "~/Scripts/AngularJS/angular-route.js",
                "~/Scripts/angular-ui/ui-bootstrap.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js"
                ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                //"~/Content/animate.css",
                "~/Content/font-awesome.css"
                //"~/Content/main.css"
                )); //Application Specific Styles

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Site/Startup").IncludeDirectory("~/Scripts/Startup", "*.js", true));
            bundles.Add(new ScriptBundle("~/Site/Template").IncludeDirectory("~/Scripts/Template", "*.js", true));
            bundles.Add(new ScriptBundle("~/Site/Controllers").IncludeDirectory("~/Scripts/Site/Controllers", "*.js", true));
            bundles.Add(new ScriptBundle("~/Site/Dialogs").IncludeDirectory("~/Scripts/Site/Dialogs", "*.js", true));
            bundles.Add(new ScriptBundle("~/Site/Directives").IncludeDirectory("~/Scripts/Site/Directives", "*.js", true));
            //bundles.Add(new ScriptBundle("~/Site/Filters").IncludeDirectory("~/Scripts/Site/Filters", "*.js", true));
            bundles.Add(new ScriptBundle("~/Site/Services").IncludeDirectory("~/Scripts/Site/Services", "*.js", true));
        }
    }
}