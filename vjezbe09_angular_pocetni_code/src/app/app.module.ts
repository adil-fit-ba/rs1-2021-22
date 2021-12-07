import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule} from "@angular/forms"
import { AppComponent } from './app.component';
import { HttpClientModule} from "@angular/common/http";
import { StudentiComponent } from './studenti/studenti.component';
import { ZaposleniciComponent } from './zaposlenici/zaposlenici.component';
import { OpstineComponent } from './opstine/opstine.component';
import { Proba1Component } from './proba1/proba1.component';
import { RouterModule } from '@angular/router';
import { EditStudentComponent } from './studenti/edit-student/edit-student.component';
import { EditZaposlenikComponent } from './zaposlenici/edit-zaposlenik/edit-zaposlenik.component';
import { DrzavaComponent } from './drzava/drzava.component';
import { DrzavaEditComponent } from './drzava/drzava-edit/drzava-edit.component';
import { Proba2Component } from './proba2/proba2.component';
import { Proba3Component } from './proba3/proba3.component';
import { Proba4Component } from './proba4/proba4.component';
import { Proba5Component } from './proba5/proba5.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentiComponent,
    ZaposleniciComponent,
    OpstineComponent,
    Proba1Component,
    EditStudentComponent,
    EditZaposlenikComponent,
    DrzavaComponent,
    DrzavaEditComponent,
    Proba2Component,
    Proba3Component,
    Proba4Component,
    Proba5Component,
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: 'studenti', component: StudentiComponent},
      {path: 'edit-student/:id', component: EditStudentComponent},
      {path: 'zaposlenici', component: ZaposleniciComponent},
      {path: 'opstine', component: OpstineComponent},
      {path: 'proba1', component: Proba1Component},
      {path: 'proba2', component: Proba2Component},
      {path: 'proba3', component: Proba3Component},
      {path: 'proba4', component: Proba4Component},
      {path: 'proba5', component: Proba5Component},
      {path: 'putanju-do-drzava', component: DrzavaComponent},
      {path: 'login', component: LoginComponent},
    ]),
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
