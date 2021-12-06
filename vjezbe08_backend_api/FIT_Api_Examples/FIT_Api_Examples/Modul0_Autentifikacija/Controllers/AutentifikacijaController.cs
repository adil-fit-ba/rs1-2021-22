using System;
using System.Collections.Generic;
using System.Linq;
using FIT_Api_Examples.Data;
using FIT_Api_Examples.Helper;
using FIT_Api_Examples.Modul0_Autentifikacija.Models;
using FIT_Api_Examples.Modul2.Models;
using FIT_Api_Examples.Modul3.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIT_Api_Examples.Modul0_Autentifikacija.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class AutentifikacijaController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public AutentifikacijaController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public class LoginVM
        {
            public string korisnickoIme { get; set; }
            public string lozinka { get; set; }
        }

        [HttpPost]
        public string Login([FromBody] LoginVM x)
        {
            //1- provjera username i password
            Nastavnik pronadjeniKorisnik = _dbContext.Nastavnik
                .SingleOrDefault(n => n.korisnickoIme == x.korisnickoIme && n.lozinka == x.lozinka);

            if (pronadjeniKorisnik == null)
                return "greska";
            //2- generisanje kljuca radnomString
            string randomString = TokenGenerator.Generate(5);

            //3- dodavanje kljuca u DB povezan sa korisnikom pronadjeniKorisnik
            var noviKljuc = new AutentifikacijaToken()
            {
                vrijemeEvidentiranja = DateTime.Now,
                vrijednost = randomString,
                korisnickiNalog = pronadjeniKorisnik
            };

            _dbContext.Add(noviKljuc);
            _dbContext.SaveChanges();

            //4- vraca kljuc radnomString
            return randomString;
        }

        [HttpGet]
        public List<CmbStavke> GetAll()
        {
            var data = _dbContext.Drzava
                .OrderBy(s => s.naziv)
                .Select(s => new CmbStavke()
                {
                    id = s.id,
                    opis = s.naziv,
                })
                .AsQueryable();
            return data.Take(100).ToList();
        }
    }
}
