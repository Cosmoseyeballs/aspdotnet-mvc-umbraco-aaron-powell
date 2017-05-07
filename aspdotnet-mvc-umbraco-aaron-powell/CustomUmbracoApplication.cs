using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Web;

namespace aspdotnet_mvc_umbraco_aaron_powell
{
    public class CustomUmbracoApplication : UmbracoApplicationBase
    {
        protected override IBootManager GetBootManager()
        {
            return new CustomWebBootManager(this);
        }
    }   

    class CustomWebBootManager : WebBootManager
    {
        public CustomWebBootManager(UmbracoApplicationBase umbracoApplication) : base(umbracoApplication)
        {
        }

        public override IBootManager Complete(Action<ApplicationContext> afterComplete)
        {
            RouteTable.Routes.MapRoute(
                "HomePage",
                "home/index",
                new { controller = "Home", action = "Index" }
            );

            return base.Complete(afterComplete);
        }
    }
}