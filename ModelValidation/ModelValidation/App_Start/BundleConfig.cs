using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ModelValidation.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-{version}.min.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js"));
            //bundles.Add(new ScriptBundle("~/bundles/jquerymin").Include("~/Scripts/jquery-{version}.min.js"));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate.js"));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryvalmin").Include("~/Scripts/jquery.validate.min.js"));
            //bundles.Add(new ScriptBundle("~/bundles/unobtrusivemin").Include("~/Scripts/jquery.validate.unobtrusive.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Site.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.min.css"));
        }
    }
}