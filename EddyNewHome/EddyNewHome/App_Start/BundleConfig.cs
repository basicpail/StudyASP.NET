﻿using System.Web;
using System.Web.Optimization;

namespace EddyNewHome
{
    public class BundleConfig
    {
        // 묶음에 대한 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=301862를 참조하세요.
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 원본 스크립트 및 CSS
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #endregion


            #region Samuel Anderson Template style 스크립트 및 CSS

            bundles.Add(new StyleBundle("~/eddyhome/css").Include(
                "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                "~/assets/vendor/fontawesome/css/font-awesome.min.css",
                "~/assets/vendor/flaticons/flaticon.css",
                "~/assets/vendor/hover/css/hover-min.css",
                "~/assets/vendor/wow/animate.css",
                "~/assets/custom/css/style.css",
                "~/assets/vendor/mfp/css/magnific-popup.css"
                ));
            bundles.Add(new ScriptBundle("~/eddyhome/js").Include(
                "~/assets/vendor/bootstrap/js/bootstrap.min.js",
                "~/assets/vendor/imagesloaded/js/imagesloaded.pkgd.min.js",
                "~/assets/vendor/isotope/js/isotope.pkgd.min.js",
                "~/assets/vendor/circle-progress/circle-progress.js",
                "~/assets/vendor/waypoints/waypoints.min.js",
                "~/assets/vendor/wow/wow.min",
                "~/assets/custom/js/custom.js"
                ));
            bundles.Add(new ScriptBundle("~/eddyhome/jquery").Include(
                "~/assets/vendor/jquery/js/jquery-2.2.0.min.js",
                "~/assets/vendor/mfp/js/jquery.magnific-popup.min.js",
                "~/assets/vendor/pjax/jquery.pjax.js"
                ));

            #endregion

        }
    }
}