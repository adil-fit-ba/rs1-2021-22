using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using FIT_Api_Examples.Modul2.Models;
using FIT_Api_Examples.Modul3.Models;

namespace FIT_Api_Examples.Modul0_Autentifikacija.Models
{
    [Table("KorisnickiNalog")]
    public class KorisnickiNalog
    {
        [Key]
        public int id { get; set; }
        public string korisnickoIme { get; set; }
        [JsonIgnore]
        public string lozinka { get; set; }
        public string slika_korisnika { get; set; }

        public Student student => this as Student;
        public Nastavnik nastavnik => this as Nastavnik;
        public bool isAdmin { get; set; }
        public bool isProdekan { get; set; }
        public bool isDekan { get; set; }
        public bool isStudentskaSluzba { get; set; }
        
 
    }
}
