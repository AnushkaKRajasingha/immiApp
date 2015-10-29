﻿Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/respond.js"))

        bundles.Add(New ScriptBundle("~/bundles/smart_wizard_scr").Include(
                  "~/Scripts/jquery.smartWizard-custom-1.0.js"))

        bundles.Add(New ScriptBundle("~/bundles/immiapp").Include(
                  "~/Scripts/mmiApp_common.js"))

        bundles.Add(New StyleBundle("~/Content/smart_wizard").Include(
                  "~/Content/smart_wizard.css",
                  "~/Content/smart_wizard_custom.css",
                   "~/Content/smart_wizard_fix.css"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/bootstrap_custom_fix.css",
                  "~/Content/site.css",
                  "~/Content/immi_custom.css",
                  "~/Content/immi_form_style.css"))

        bundles.Add(New StyleBundle("~/Content/font-awsome").Include(
                  "~/Content/font-awesome/css/font-awesome.css",
                 "~/Content/font-awesome/css/font-awesome-custom.css"))
    End Sub
End Module

