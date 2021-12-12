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
import {AuthGuard} from "./_guards";
import { RegistracijaComponent } from './registracija/registracija.component';

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
    RegistracijaComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: 'studenti', component: StudentiComponent, canActivate: [AuthGuard]},
      {path: 'edit-student/:id', component: EditStudentComponent, canActivate: [AuthGuard]},
      {path: 'zaposlenici', component: ZaposleniciComponent, canActivate: [AuthGuard]},
      {path: 'opstine', component: OpstineComponent, canActivate: [AuthGuard]},
      {path: 'proba1', component: Proba1Component, canActivate: [AuthGuard]},
      {path: 'proba2', component: Proba2Component, canActivate: [AuthGuard]},
      {path: 'proba3', component: Proba3Component, canActivate: [AuthGuard]},
      {path: 'proba4', component: Proba4Component, canActivate: [AuthGuard]},
      {path: 'proba5', component: Proba5Component, canActivate: [AuthGuard]},
      {path: 'putanju-do-drzava', component: DrzavaComponent, canActivate: [AuthGuard]},
      {path: 'login', component: LoginComponent},
      {path: 'registracija', component: RegistracijaComponent},
    ]),
    FormsModule,
    HttpClientModule
  ],
  providers: [
    AuthGuard,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
