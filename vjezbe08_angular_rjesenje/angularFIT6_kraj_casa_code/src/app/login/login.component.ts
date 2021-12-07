import { Component, OnInit } from '@angular/core';
import {MojConfig} from "../moj-config";
import {HttpClient} from "@angular/common/http";
import {Router} from "@angular/router";

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
    let saljemo = {korisnickoIme:this.txtKorisnickoIme, lozinka:this.txtLozinka};
    this.httpKlijent.post(MojConfig.adresa_servera+ "/Autentifikacija/Login", saljemo, {responseType:"text"})
      .subscribe((x:any)=>{
          //spremiti token x u local storage
          localStorage.setItem("autentifikacija-token", x)

        if (x!="greska") {
          //redirect na login putanju
          this.router.navigateByUrl("/studenti");
        }
        else {
          alert("pogresan username i/ili password");
        }
      });
  }
}
