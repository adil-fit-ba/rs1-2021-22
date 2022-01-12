using System;
using System.Collections.Generic;
using System.Linq;
using FIT_Api_Examples.Data;
using FIT_Api_Examples.Helper;
using FIT_Api_Examples.Helper.AutentifikacijaAutorizacija;
using FIT_Api_Examples.Modul0_Autentifikacija.Models;
using FIT_Api_Examples.Modul2.Models;
using FIT_Api_Examples.Modul3.Models;
using FIT_Api_Examples.Modul3.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FIT_Api_Examples.Modul3.Controllers
{
  
    [Route("[controller]/[action]")]
    public class MvcIspitController: Controller
    {
        private ApplicationDbContext _dbContext;

        public MvcIspitController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult OdabirDatuma()
        {


            return View("OdabirDatuma");
        }

        [HttpGet]
        public ActionResult Obrisi(int IspitID)
        {
            Ispit ispit = _dbContext.Ispit.Find(IspitID);
            _dbContext.Remove(ispit);
            _dbContext.SaveChanges();
            return Redirect("/MvcIspit/GetByDatum");
        }

        [HttpGet]
        public ActionResult GetByDatum(DateTime? periodOd, DateTime? periodDo)
        {
            List<Ispit> podaci = _dbContext.Ispit
                .Include(s=>s.predmet)
                .Where(x=> periodOd ==null || x.DatumIspita>= periodOd )
                .Where(x=> periodDo == null || x.DatumIspita <= periodDo)
                .ToList();

            ViewData["podaciKey"] = podaci;
            ViewData["periodOdKey"] = periodOd;
            ViewData["periodDoKey"] = periodDo;


            return View("GetByDatum");
        }

  




    }
}
