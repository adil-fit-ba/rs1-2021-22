
  export interface Drzava {
    id: number;
    naziv: string;
  }

  export interface OpstinaRodjenja {
    id: number;
    description: string;
    drzava_id: number;
    drzava: Drzava;
  }

  export class StudentPrikazVm {
  id: number;
  ime: string;
  prezime: string;

    constructor(id: number, ime: string, prezime: string) {
      this.id = id;
      this.ime = ime;
      this.prezime = prezime;
    }
  }


