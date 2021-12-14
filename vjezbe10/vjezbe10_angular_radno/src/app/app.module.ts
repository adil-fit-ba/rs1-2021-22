import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule} from "@angular/forms"
import { AppComponent } from './app.component';
import { HttpClientModule} from "@angular/common/http";
import { StudentiComponent } from './studenti/studenti.component';
import { OpstineComponent } from './opstine/opstine.component';
import { Proba1Component } from './proba/proba1/proba1.component';
import { RouterModule } from '@angular/router';
import { EditStudentComponent } from './studenti/edit-student/edit-student.component';
import { DrzavaComponent } from './drzava/drzava.component';
import { DrzavaEditComponent } from './drzava/drzava-edit/drzava-edit.component';
import { Proba2Component } from './proba/proba2/proba2.component';
import { Proba3Component } from './proba/proba3/proba3.component';
import { Proba4Component } from './proba/proba4/proba4.component';
import { Proba5Component } from './proba/proba5/proba5.component';
import { LoginComponent } from './login/login.component';
import { RegistracijaComponent } from './registracija/registracija.component';
import { NastavniciComponent } from './nastavnici/nastavnici.component';
import { HomeStudentComponent } from './home-student/home-student.component';
import { HomeZaposlenikComponent } from './home-zaposlenik/home-zaposlenik.component';
import { HomeComponent } from './home/home.component';
import {AutorizacijaStudentskaSluzbaProvjera} from "./_guards/autorizacija-studentska-sluzba-provjera.service";
import {AutorizacijaLoginProvjera} from "./_guards/autorizacija-login-provjera.service";
import { NotFoundComponent } from './not-found/not-found.component';
import {AutorizacijaAdminProvjera} from "./_guards/autorizacija-admin-provjera.service";

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
    HomeStudentComponent,
    HomeZaposlenikComponent,
    HomeComponent,
    NotFoundComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: 'studenti', component: StudentiComponent, canActivate: [AutorizacijaStudentskaSluzbaProvjera]},
      {path: 'edit-student/:id', component: EditStudentComponent, canActivate: [AutorizacijaStudentskaSluzbaProvjera]},
      {path: 'nastavnici', component: NastavniciComponent, canActivate: [AutorizacijaAdminProvjera]},
      {path: 'opstine', component: OpstineComponent , canActivate: [AutorizacijaStudentskaSluzbaProvjera]},
      {path: 'proba1', component: Proba1Component},
      {path: 'proba2', component: Proba2Component},
      {path: 'proba3', component: Proba3Component},
      {path: 'proba4', component: Proba4Component},
      {path: 'proba5', component: Proba5Component},
      {path: 'drzave', component: DrzavaComponent, canActivate: [AutorizacijaStudentskaSluzbaProvjera]},
      {path: 'home-student', component: HomeStudentComponent, canActivate: [AutorizacijaLoginProvjera]},
      {path: 'home-zaposlenik', component: HomeZaposlenikComponent, canActivate: [AutorizacijaLoginProvjera]},
      {path: 'login', component: LoginComponent},
      {path: 'registracija', component: RegistracijaComponent},
      {path: '**', component: NotFoundComponent, canActivate: [AutorizacijaLoginProvjera]},
    ]),
    FormsModule,
    HttpClientModule
  ],
  providers: [
    AutorizacijaAdminProvjera,
    AutorizacijaLoginProvjera,
    AutorizacijaStudentskaSluzbaProvjera
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
