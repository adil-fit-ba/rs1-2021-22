﻿using System;
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
            HttpContext httpContext = filterContext.HttpContext;

            KorisnickiNalog k = httpContext.GetKorisnikOfAuthToken();

            if (k == null)
            {
                filterContext.Result = new UnauthorizedResult();
                return;
            }

            KretanjePoSistemu.Save(httpContext);

            //studenti mogu pristupiti 
            if (k.korisnickoIme.StartsWith("a"))
            {
                return;//ok - ima pravo pristupa
            }

            //else nema pravo pristupa
            filterContext.Result = new UnauthorizedResult();
        }
    }
}
