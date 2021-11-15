import {Component, Input, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {MojConfig} from "../../moj-config";

declare function porukaSuccess(p:string): any;

@Component({
  selector: 'app-edit-student',
  templateUrl: './edit-student.component.html',
  styleUrls: ['./edit-student.component.css']
})
export class EditStudentComponent implements OnInit {

  ngOnInit(): void {
  }

  constructor(private http:HttpClient) {
  }

  snimi() {
    this.http.post(MojConfig.adresa_servera + "/Student/Update/" + this.editStudent.id, this.editStudent, MojConfig.http_opcije).subscribe((x)=>{
      porukaSuccess("uspjesno snimljeno");
    });
  }

  @Input() editStudent: any;
}
