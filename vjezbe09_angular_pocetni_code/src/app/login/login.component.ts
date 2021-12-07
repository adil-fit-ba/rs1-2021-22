import { Component, OnInit } from '@angular/core';
import {MojConfig} from "../moj-config";
import {HttpClient} from "@angular/common/http";
import {Router} from "@angular/router";

declare function porukaSuccess(a: string):any;
declare function porukaError(a: string):any;

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  txtLozinka: any;
  txtKorisnickoIme: any;

  constructor(private httpKlijent: HttpClient, private router: Router) {
  }

  ngOnInit(): void {
  }

  btnLogin() {
    let saljemo = {
      korisnickoIme:this.txtKorisnickoIme,
      lozinka: this.txtLozinka
    };
    this.httpKlijent.post(MojConfig.adresa_servera+ "/Autentifikacija/Login/", saljemo)
      .subscribe((x:any) =>{
        if (x!=null) {
          porukaSuccess("uspjesan login");
          localStorage.setItem("autentifikacija-token", x.vrijednost);

          this.router.navigateByUrl("/studenti");

        }
        else
        {
          localStorage.setItem("autentifikacija-token", "");
          porukaError("neispravan login");
        }
      });
  }
}
