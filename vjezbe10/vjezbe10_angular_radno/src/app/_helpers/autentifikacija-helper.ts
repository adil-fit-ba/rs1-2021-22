
export class AutentifikacijaHelper {

  static setKorisnik(korisnik: any):void
  {
      localStorage.setItem("autentifikacija-token", korisnik);
  }

  static getKorisnik():any
  {
      let korisnik= localStorage.getItem("autentifikacija-token");
      if (korisnik === "")
        return null;
      return korisnik;
  }
}
