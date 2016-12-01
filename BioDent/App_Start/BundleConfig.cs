using System.Web;
using System.Web.Optimization;

namespace BioDent
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region ESTILOS DE BIODENT
            bundles.Add(new StyleBundle("~/Content/BioDentStyles").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/bootstrap-responsive.css",
                "~/Content/css/stilearn.css",
                "~/Content/css/stilearn-responsive.css",
                "~/Content/css/stilearn-helper.css",
                "~/Content/css/stilearn-icon.css",
                "~/Content/css/font-awesome.css",
                "~/Content/css/animate.css",
                "~/Content/css/uniform.default.css",
                "~/Content/css/select2.css",
                "~/Content/css/fullcalendar.css",
                "~/Content/css/bootstrap-wysihtml5.css",
                "~/Content/css/DT_bootstrap.css",
                "~/Content/css/responsive-tables.css"
            ));
            #endregion

            #region SCRIPTS DE BIODENT

            bundles.Add(new ScriptBundle("~/Content/BioDentScripts").Include(
                "~/Content/js/jquery.js",
                "~/Content/js/jquery-ui.min.js",
                "~/Content/js/bootstrap.js",
                "~/Content/js/uniform/jquery.uniform.js",
                "~/Content/js/datepicker/bootstrap-datepicker.js",
                "~/Content/js/datatables/jquery.dataTables.min.js",
                "~/Content/js/datatables/extras/ZeroClipboard.js",
                "~/Content/js/datatables/extras/TableTools.min.js",
                "~/Content/js/datatables/DT_bootstrap.js",
                "~/Content/js/responsive-tables/responsive-tables.js",
                "~/Content/js/peity/jquery.peity.js",
                "~/Content/js/select2/select2.js",
                "~/Content/js/knob/jquery.knob.js",
                "~/Content/js/flot/jquery.flot.js",
                "~/Content/js/flot/jquery.flot.resize.js",
                "~/Content/js/flot/jquery.flot.categories.js",
                "~/Content/js/wysihtml5/wysihtml5-0.3.0.js",
                "~/Content/js/wysihtml5/bootstrap-wysihtml5.js",
                "~/Content/js/calendar/fullcalendar.js",
                "~/Content/js/holder.js",
                "~/Content/js/stilearn-base.js"
            ));

            #endregion
        }
    }
}
