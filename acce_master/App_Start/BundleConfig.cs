using System.Web;
using System.Web.Optimization;

namespace acce_master
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/content/js/ace-elements.min").Include(
                        "~/content/js/ace-elements.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/ace-editable.min").Include(
                        "~/content/js/ace-editable.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/ace-extra.min").Include(
                        "~/content/js/ace-extra.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/ace.min").Include(
                        "~/content/js/ace.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/autosize.min").Include(
                        "~/content/js/autosize.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootbox").Include(
                        "~/content/js/bootboxjs"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-colorpicker.min").Include(
                        "~/content/js/bootstrap-colorpicker.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-datepicker.min").Include(
                     "~/content/js/bootstrap-datepicker.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-datetimepicker.min").Include(
                     "~/content/js/bootstrap-datetimepicker.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-editable.min").Include(
                     "~/content/js/bootstrap-editable.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-markdown.min").Include(
                     "~/content/js/bootstrap-markdown.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-multiselect.min").Include(
                     "~/content/js/bootstrap-multiselect.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-tag.min").Include(
                     "~/content/js/bootstrap-tag.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-timepicker.min").Include(
                     "~/content/js/bootstrap-timepicker.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap-wysiwyg.min").Include(
                     "~/content/js/bootstrap-wysiwyg.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/bootstrap.min").Include(
                     "~/content/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/buttons.colVis.min").Include(
                     "~/content/js/buttons.colVis.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/buttons.flash.min").Include(
                     "~/content/js/buttons.flash.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/buttons.html5.min").Include(
                     "~/content/js/buttons.html5.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/buttons.print.min").Include(
                     "~/content/js/buttons.print.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/chosen.jquery.min").Include(
                     "~/content/js/chosen.jquery.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/dataTables.buttons.min").Include(
                     "~/content/js/dataTables.buttons.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/dataTables.select.min").Include(
                     "~/content/js/dataTables.select.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/daterangepicker.min").Include(
                     "~/content/js/daterangepicker.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/dropzone.min").Include(
                     "~/content/js/dropzone.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/excanvas.min").Include(
                     "~/content/js/excanvas.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/fullcalendar.min").Include(
                     "~/content/js/fullcalendar.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/fullcalendar").Include(
                     "~/content/js/fullcalendar.js"));
            bundles.Add(new ScriptBundle("~/content/js/holder.min").Include(
                     "~/content/js/holder.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/html5shiv.min").Include(
                     "~/content/js/html5shiv.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery-1.11.3.min").Include(
                     "~/content/js/jquery-1.11.3.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery-2.1.4.min").Include(
                     "~/content/js/jquery-2.1.4.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery-additional-methods.min").Include(
                     "~/content/js/jquery-additional-methods.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery-typeahead").Include(
                     "~/content/js/jquery-typeahead.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery-ui.custom.min").Include(
                    "~/content/js/jquery-ui.custom.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery-ui.min").Include(
                    "~/content/js/jquery-ui.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.bootstrap-duallistbox.min").Include(
                    "~/content/js/jquery.bootstrap-duallistbox.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.colorbox.min").Include(
                    "~/content/js/jquery.colorbox.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.dataTables.bootstrap.min").Include(
                    "~/content/js/jquery.dataTables.bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.dataTables.min").Include(
                    "~/content/js/jquery.dataTables.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.easypiechart.min").Include(
                    "~/content/js/jquery.easypiechart.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.flot.min").Include(
                    "~/content/js/jquery.flot.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.flot.pie.min").Include(
                    "~/content/js/jquery.flot.pie.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.flot.resize.min").Include(
                    "~/content/js/jquery.flot.resize.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.gritter.min").Include(
                    "~/content/js/jquery.gritter.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.hotkeys.index.min").Include(
                    "~/content/js/jquery.hotkeys.index.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.inputlimiter.min").Include(
                    "~/content/js/jquery.inputlimiter.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.jqGrid.min").Include(
                    "~/content/js/jquery.jqGrid.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.knob.min").Include(
                    "~/content/js/jquery.knob.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.maskedinput.min").Include(
                    "~/content/js/jquery.maskedinput.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.mobile.custom.min").Include(
                    "~/content/js/jquery.mobile.custom.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.nestable.min").Include(
                    "~/content/js/jquery.nestable.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.raty.min").Include(
                    "~/content/js/jquery.raty.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.sparkline.index.min").Include(
                    "~/content/js/jquery.sparkline.index.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.ui.touch-punch.min").Include(
                    "~/content/js/jquery.ui.touch-punch.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/jquery.validate.min").Include(
                    "~/content/js/jquery.validate.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/markdown.min").Include(
                    "~/content/js/markdown.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/moment.min").Include(
                    "~/content/js/moment.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/prettify.min").Include(
                    "~/content/js/prettify.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/respond.min").Include(
                    "~/content/js/respond.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/select2.min").Include(
                    "~/content/js/select2.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/spin").Include(
                    "~/content/js/spin.js"));
            bundles.Add(new ScriptBundle("~/content/js/spinbox.min").Include(
                    "~/content/js/spinbox.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/tree.min").Include(
                    "~/content/js/tree.min.js"));
            bundles.Add(new ScriptBundle("~/content/js/wizard.min").Include(
                    "~/content/js/wizard.min.js"));
            bundles.Add(new StyleBundle("~/content/css/ace-ie.min").Include(
                "~/content/css/ace-ie.min.css"));
            bundles.Add(new StyleBundle("~/content/css/ace-part2.min").Include(
                "~/content/css/ace-part2.min.css"));
            bundles.Add(new StyleBundle("~/content/css/ace-rtl.min").Include(
                "~/content/css/ace-rtl.min.css"));
            bundles.Add(new StyleBundle("~/content/css/ace-skins.min").Include(
                "~/content/css/ace-skins.min.css"));
            bundles.Add(new StyleBundle("~/content/css/ace.min.min").Include(
                "~/content/css/ace.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap-colorpicker.min").Include(
                "~/content/css/bootstrap-colorpicker.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap-datepicker3.min").Include(
                "~/content/css/bootstrap-datepicker3.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap-datetimepicker.min").Include(
               "~/content/css/bootstrap-datetimepicker.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap-duallistbox.min").Include(
               "~/content/css/bootstrap-duallistbox.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap-editable.min").Include(
               "~/content/css/bootstrap-editable.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap-multiselect.min").Include(
               "~/content/css/bootstrap-multiselect.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap-timepicker.min").Include(
               "~/content/css/bootstrap-timepicker.min.css"));
            bundles.Add(new StyleBundle("~/content/css/bootstrap.min").Include(
              "~/content/css/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/content/css/chosen.min").Include(
              "~/content/css/chosen.min.css"));
            bundles.Add(new StyleBundle("~/content/css/colorbox.min").Include(
             "~/content/css/colorbox.min.css"));
            bundles.Add(new StyleBundle("~/content/css/daterangepicker.min").Include(
             "~/content/css/daterangepicker.min.css"));
            bundles.Add(new StyleBundle("~/content/css/dropzone.min").Include(
            "~/content/css/dropzone.min.css"));
            bundles.Add(new StyleBundle("~/content/css/font-awesome.min").Include(
            "~/content/css/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/content/css/fonts.googleapis.com").Include(
            "~/content/css/fonts.googleapis.com.css"));
            bundles.Add(new StyleBundle("~/content/css/fullcalendar.min").Include(
            "~/content/css/fullcalendar.min.css"));
            bundles.Add(new StyleBundle("~/content/css/jquery-ui.custom.min").Include(
            "~/content/css/jquery-ui.custom.min.css"));
            bundles.Add(new StyleBundle("~/content/css/jquery-ui.min").Include(
            "~/content/css/jquery-ui.min.css"));
            bundles.Add(new StyleBundle("~/content/css/jquery.gritter.min").Include(
            "~/content/css/jquery.gritter.min.css"));
            bundles.Add(new StyleBundle("~/content/css/prettify.min").Include(
           "~/content/css/prettify.min.css"));
            bundles.Add(new StyleBundle("~/content/css/select2.min").Include(
          "~/content/css/select2.min.css"));
           bundles.Add(new StyleBundle("~/content/css/ui.jqgrid.min").Include(
          "~/content/css/ui.jqgrid.min.css"));

        }
    }
}
