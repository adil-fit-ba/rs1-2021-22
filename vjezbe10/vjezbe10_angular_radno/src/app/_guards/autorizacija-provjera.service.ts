import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { AutentifikacijaHelper} from "../_helpers/autentifikacija-helper";

@Injectable()
export class AutorizacijaProvjera implements CanActivate {

    constructor(private router: Router) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {

      if (AutentifikacijaHelper.getLoginInfo().isPermsijaAdmin)
        return true;


      if (AutentifikacijaHelper.getLoginInfo().isLogiran) {

        if (route.component == "nastavnici")
        {
            if (AutentifikacijaHelper.getLoginInfo().isPermsijaAdmin)
              return true;
        }
        else if (route.component == "drzave")
        {
            if (AutentifikacijaHelper.getLoginInfo().isPermisijaStudentskaSluzba)
               return true;
        }else {


          return true;
        }
      }

        // not logged in so redirect to login page with the return url
        this.router.navigate(['login'], { queryParams: { returnUrl: state.url }});
        return false;
    }
}
