import { Injectable } from '@angular/core';
import * as signalR from "@microsoft/signalr";
import {MojConfig} from "../moj-config";
import {ChartModel} from "../singalr-chart-primjer/chart-model";  //
@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  public nizPodataka: ChartModel[];

  constructor() { }
  private hubConnection: signalR.HubConnection

  startConnection() {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(MojConfig.adresa_servera+ '/signalr-ws-putanja1-chart') //pogledati startup.cs
      .build();
    this.hubConnection
      .start()
      .then(() => console.log('Connection started'))
      .catch(err => console.log('Error while starting connection: ' + err))
  }

  addTransferChartDataListener() {
    //transferchartdata pogledati SignalrPrimjer1ChartController
    this.hubConnection.on('transferchartdata', (data) => {
      this.nizPodataka = data;
      console.log(data);
    });
  }

  pozoviMetodaHub1() {
    let p = {
      vrijeme:new Date(),
      a:1,
      b:2
    }
    this.hubConnection.invoke('MetodaHub1', p)
      .catch(err => console.error(err));
  }
}
