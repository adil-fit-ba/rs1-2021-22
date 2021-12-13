import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule} from "@angular/forms"
import { AppComponent } from './app.component';
import { HttpClientModule} from "@angular/common/http";
import { StudentiComponent } from './studenti/studenti.component';
import { OpstineComponent } from './opstine/opstine.component';
import { Proba1Component } from './proba1/proba1.component';
import { RouterModule } from '@angular/router';
import { EditStudentComponent } from './studenti/edit-student/edit-student.component';
import { DrzavaComponent } from './drzava/drzava.component';
import { DrzavaEditComponent } from './drzava/drzava-edit/drzava-edit.component';
import { Proba2Component } from './proba2/proba2.component';
import { Proba3Component } from './proba3/proba3.component';
import { Proba4Component } from './proba4/proba4.component';
import { Proba5Component } from './proba5/proba5.component';
import { LoginComponent } from './login/login.component';
import {AutorizacijaProvjera} from "./_guards";
import { RegistracijaComponent } from './registracija/registracija.component';
import { NastavniciComponent } from './nastavnici/nastavnici.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentiComponent,
    OpstineComponent,
    Proba1Component,
    EditStudentComponent,
    DrzavaComponent,
    DrzavaEditComponent,
    Proba2Component,
    Proba3Component,
    Proba4Component,
    Proba5Component,
    LoginComponent,
    RegistracijaComponent,
    NastavniciComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: 'studenti', component: StudentiComponent, canActivate: [AutorizacijaProvjera]},
      {path: 'edit-student/:id', component: EditStudentComponent, canActivate: [AutorizacijaProvjera]},
      {path: 'nastavnici', component: NastavniciComponent, canActivate: [AutorizacijaProvjera]},
      {path: 'opstine', component: OpstineComponent, canActivate: [AutorizacijaProvjera]},
      {path: 'proba1', component: Proba1Component, canActivate: [AutorizacijaProvjera]},
      {path: 'proba2', component: Proba2Component, canActivate: [AutorizacijaProvjera]},
      {path: 'proba3', component: Proba3Component, canActivate: [AutorizacijaProvjera]},
      {path: 'proba4', component: Proba4Component, canActivate: [AutorizacijaProvjera]},
      {path: 'proba5', component: Proba5Component, canActivate: [AutorizacijaProvjera]},
      {path: 'drzave', component: DrzavaComponent, canActivate: [AutorizacijaProvjera]},
      {path: 'login', component: LoginComponent},
      {path: 'registracija', component: RegistracijaComponent},
    ]),
    FormsModule,
    HttpClientModule
  ],
  providers: [
    AutorizacijaProvjera,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
