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
import { EditZaposleniciComponent } from './zaposlenici/edit-zaposlenici/edit-zaposlenici.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentiComponent,
    ZaposleniciComponent,
    OpstineComponent,
    Proba1Component,
    EditStudentComponent,
    EditZaposleniciComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: 'studenti', component: StudentiComponent},
      {path: 'zaposlenici', component: ZaposleniciComponent},
      {path: 'opstine', component: OpstineComponent},
      {path: 'proba1', component: Proba1Component},
    ]),
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
