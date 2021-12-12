import {HttpHeaders} from "@angular/common/http";

export class MojConfig{
  static adresa_servera = "https://localhost:44326";
  static http_opcije= function (){

    return {
        headers: {
        'autentifikacija-token': 't1001',
      }
    };
  }

}
