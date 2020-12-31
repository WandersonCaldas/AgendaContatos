using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.MVC.Controllers
{
    public class BaseController : System.Web.Mvc.Controller
    {
        protected override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            if (Session["cod_usuario"] == null)
            {
                Session.Abandon();
                filterContext.Result = RedirectToAction("Index", "Account");
            }
            else
            {
                base.OnActionExecuting(filterContext);
            }
        }
    }
}