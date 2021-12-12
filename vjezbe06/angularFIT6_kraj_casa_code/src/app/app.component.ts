import { Component } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {MojConfig} from "./moj-config";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string = 'angularFIT2';
  ime:string = '';
  brojac: number=0;
  niz:string[]=['jedan', 'dva', 'tri', 'četiri'];
  studentPodaci: any;

  constructor(private httpKlijent: HttpClient) {
  }

  testirajString() :void
  {
    this.brojac++;
    this.ime += "." + this.brojac;
  }

  testirajWebApi() :void
  {
    this.httpKlijent.get(MojConfig.adresa_servera+ "/Student/GetAll").subscribe(x=>{
      this.studentPodaci = x;
    });
  }

  pokreniTimer() :void
  {
    setInterval(()=>{
      this.brojac++;
    }, 1000);
  }

  jelVidljivo() :boolean {
    return this.ime.length>0
  }

  mojStyle() {
    return (this.brojac%2==0)?{'color':'blue', 'border':'1px solid blue'}: {'color': 'red'}
  }

  getStudentPodaci() {
    return this.studentPodaci.filter((x: any)=> x.ime.length==0 || (x.ime + " " + x.prezime).toLowerCase().startsWith(this.ime.toLowerCase()) || (x.prezime + " " + x.ime).toLowerCase().startsWith(this.ime.toLowerCase()));
  }
}
