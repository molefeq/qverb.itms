﻿using QverbITMS.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace QverbITMS.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            BundleTable.Bundles.IgnoreList.Clear(); // apparently, IgnoreList included .min.js in debug
            BundleTable.Bundles.IgnoreList.Ignore(".intellisense.js", OptimizationMode.Always);
            BundleTable.Bundles.IgnoreList.Ignore("-vsdoc.js", OptimizationMode.Always);
            BundleTable.Bundles.IgnoreList.Ignore(".debug.js", OptimizationMode.Always);

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();


            // initialize engine context
            EngineContext.Initialize(false);   
        }
    }
}