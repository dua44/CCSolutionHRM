using System.Web;
using System.Web.Optimization;

namespace CCSolutionHRM
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryUI").Include("~/Scripts/jquery-ui-1.9.2.custom.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryXlib").Include(
                "~/js/lib/jquery/jquery.min.js",
                "~/js/sidebarmenu.js",
                "~/js/lib/bootstrap/js/bootstrap.min.js",
                "~/js/lib/bootstrap/js/popper.min.js",
                "~/js/jquery.slimscroll.js",
                "~/js/lib/sticky-kit-master/dist/sticky-kit.min.js",
                "~/js/lib/toastr/toastr.min.js",
                "~/js/custom.min.js",
                "~/js/lib/datatables/datatables.min.js",
                "~/js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js",
                "~/js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js",
                "~/js/lib/datatables/cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js",
                "~/js/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/pdfmake.min.js",
                "~/js/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/vfs_fonts.js",
                "~/js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js",
                "~/js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.print.min.js",
                "~/js/lib/datatables/datatables-init.js",
                "~/js/lib/datamap/d3.min.js",
                "~/js/lib/datamap/topojson.js",
                "~/js/lib/datamap/datamaps.world.min.js",
                "~/js/lib/datamap/datamap-init.js",
                "~/js/lib/weather/jquery.simpleWeather.min.js",
                "~/js/lib/weather/weather-init.js",
                "~/js/lib/owl-carousel/owl.carousel.min.js",
                "~/js/lib/owl-carousel/owl.carousel-init.js",
                "~/js/lib/chartist/chartist.min.js",
                "~/js/lib/chartist/chartist-plugin-tooltip.min.js",
                "~/js/lib/chartist/chartist-init.js",
                "~/js/custom.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/css/lib/toastr/toastr.min.css",
                "~/css/lib/chartist/chartist.min.css",
                "~/css/lib/owl.carousel.min.css",
                "~/css/lib/owl.theme.default.min.css",
                "~/css/lib/bootstrap/bootstrap.min.css",
                "~/css/helper.css",
                "~/css/style.css"));



        }
    }
}
