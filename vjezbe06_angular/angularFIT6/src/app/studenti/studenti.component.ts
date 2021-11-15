import { Component, OnInit } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {MojConfig} from "../moj-config";

@Component({
  selector: 'app-studenti',
  templateUrl: './studenti.component.html',
  styleUrls: ['./studenti.component.css']
})
export class StudentiComponent implements OnInit {

  title:string = 'angularFIT2';
  ime:string = '';
  brojac: number=0;
  niz:string[]=['jedan', 'dva', 'tri', 'četiri'];
  studentPodaci: any;
  odabraniStudent: any;

  constructor(private httpKlijent: HttpClient) {
  }

  testirajWebApi() :void
  {
    this.httpKlijent.get(MojConfig.adresa_servera+ "/Student/GetAll").subscribe(x=>{
      this.studentPodaci = x;
    });
  }


  getStudentPodaci() {
    if (this.studentPodaci == null)
      return [];
    return this.studentPodaci.filter((x: any)=> x.ime.length==0 || (x.ime + " " + x.prezime).toLowerCase().startsWith(this.ime.toLowerCase()) || (x.prezime + " " + x.ime).toLowerCase().startsWith(this.ime.toLowerCase()));
  }

  ngOnInit(): void {
  }

  detalji(s:any) {
    this.odabraniStudent = s;
  }
}
