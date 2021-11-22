using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Day1_Helloworld.Models
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
            base.OnActionExecuting(filterContext);
            
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
            base.OnActionExecuted(filterContext);
        }

        
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
            base.OnResultExecuted(filterContext);
        }

        public void Log(string actionName, RouteData routeData)
        {
            var ctrl = routeData.Values["controller"];
            var action = routeData.Values["action"];

            var str = String.Format("{0} action is executed from {1} Controller ", action, ctrl);

            Debug.WriteLine(str);
        }
    }
}