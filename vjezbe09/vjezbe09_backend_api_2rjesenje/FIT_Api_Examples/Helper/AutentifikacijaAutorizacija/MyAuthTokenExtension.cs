﻿using System.Linq;
using FIT_Api_Examples.Data;
using FIT_Api_Examples.Modul0_Autentifikacija.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FIT_Api_Examples.Helper.AutentifikacijaAutorizacija
{
    public static class MyAuthTokenExtension
    {

         public static KorisnickiNalog GetKorisnikOfAuthToken(this HttpContext httpContext)
        {
            string token = httpContext.GetMyAuthToken();
            ApplicationDbContext db = httpContext.RequestServices.GetService<ApplicationDbContext>();

            KorisnickiNalog korisnickiNalog = db.AutentifikacijaToken.Where(x => token != null && x.vrijednost == token).Select(s => s.korisnickiNalog).SingleOrDefault();
            return korisnickiNalog;
        }
    

        public static string GetMyAuthToken(this HttpContext httpContext)
        {
            string token = httpContext.Request.Headers["autentifikacija-token"];
            return token;
        }
    }
}
