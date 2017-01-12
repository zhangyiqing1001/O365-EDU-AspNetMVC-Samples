﻿using EDUGraphAPI.Web.Services;
using System.Web.Mvc;

namespace EDUGraphAPI.Web.Controllers
{
    public class DemoHelperController : Controller
    {
        private DemoHelperService demoHelperService;

        public DemoHelperController(DemoHelperService demoHelperService)
        {
            this.demoHelperService = demoHelperService;
        }

        public ActionResult Control()
        {
            var parentActionRouteData = this.ControllerContext.ParentActionViewContext.RouteData;
            var page = demoHelperService.GetDemoPage(
                parentActionRouteData.GetRequiredString("controller"),
                parentActionRouteData.GetRequiredString("action"));
            return PartialView(page);
        }
    }
}