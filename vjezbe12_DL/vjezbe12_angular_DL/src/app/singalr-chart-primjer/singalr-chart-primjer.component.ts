import { Component, OnInit } from '@angular/core';
import {SignalRService} from "../services/signal-r.service";

@Component({
  selector: 'app-singalr-chart-primjer',
  templateUrl: './singalr-chart-primjer.component.html',
  styleUrls: ['./singalr-chart-primjer.component.css']
})
export class SingalrChartPrimjerComponent implements OnInit {

  constructor(public signalRService: SignalRService, ) { }

  ngOnInit(): void {
    this.signalRService.startConnection();
    this.signalRService.addTransferChartDataListener();
  }

  public chartOptions: any = {
    scaleShowVerticalLines: true,
    responsive: true,
    animation:{
      duration:0
    },
    scales: {
      yAxes: [{
        ticks: {
          beginAtZero: true
        }
      }]
    }
  };
  public chartLabels: string[] = ['Real time data for the chart'];
  public chartType = 'bar' as const;
  public chartLegend: boolean = true;
  public colors: any[] = [{ backgroundColor: '#5491DA' }, { backgroundColor: '#E74C3C' }, { backgroundColor: '#82E0AA' }, { backgroundColor: '#E5E7E9' }]


  chartClicked($event: { event?: MouseEvent; active?: {}[] }) {

  }

  pozoviMetodaHub1() {
    this.signalRService.pozoviMetodaHub1();
  }
}
