using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FIT_Api_Examples.Modul0_Autentifikacija.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FIT_Api_Examples.Helper.AutentifikacijaAutorizacija
{
    public class AutorizacijaAttribute : TypeFilterAttribute
    {
        public AutorizacijaAttribute()
            : base(typeof(MyAuthorizeImpl))
        {
            Arguments = new object[] {  };
        }
    }


    public class MyAuthorizeImpl : IActionFilter
    {
   
        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (filterContext.HttpContext.GetLoginInfo().isLogiran)
            {
                filterContext.Result = new UnauthorizedResult();
                return;
            }

            KretanjePoSistemu.Save(filterContext.HttpContext);

            //isPermisijaStudentskaSluzba
            if (filterContext.HttpContext.GetLoginInfo().isPermisijaStudentskaSluzba)
            {
                return;//ok - ima pravo pristupa
            }

            //else nema pravo pristupa
            filterContext.Result = new UnauthorizedResult();
        }
    }
}
