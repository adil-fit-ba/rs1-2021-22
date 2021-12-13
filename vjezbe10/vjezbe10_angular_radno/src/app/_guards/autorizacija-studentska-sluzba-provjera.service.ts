﻿import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { AutentifikacijaHelper} from "../_helpers/autentifikacija-helper";
import {NastavniciComponent} from "../nastavnici/nastavnici.component";
import {DrzavaComponent} from "../drzava/drzava.component";
import {OpstineComponent} from "../opstine/opstine.component";

@Injectable()
export class AutorizacijaStudentskaSluzbaProvjera implements CanActivate {

    constructor(private router: Router) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {

        if (AutentifikacijaHelper.getLoginInfo().isPermisijaStudentskaSluzba)
          return true;

        // not logged in so redirect to login page with the return url
        this.router.navigate([''], { queryParams: { returnUrl: state.url }});
        return false;
    }
}