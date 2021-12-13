import {HttpHeaders} from "@angular/common/http";
import {AutentifikacijaHelper} from "./_helpers/autentifikacija-helper";

export class MojConfig{
  static adresa_servera = "https://localhost:44326";
  static http_opcije= function (){

    let mojtoken = AutentifikacijaHelper.getLoginInfo().autentifikacijaToken.vrijednost;
    return {
        headers: {
        'autentifikacija-token': mojtoken,
      }
    };
  }

}
