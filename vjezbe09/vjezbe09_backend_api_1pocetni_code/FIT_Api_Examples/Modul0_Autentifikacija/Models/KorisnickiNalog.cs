using System.ComponentModel.DataAnnotations;

namespace FIT_Api_Examples.Modul0_Autentifikacija.Models
{
    public class KorisnickiNalog
    {
        [Key]
        public int id { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public string slika_korisnika { get; set; }

    }
}
