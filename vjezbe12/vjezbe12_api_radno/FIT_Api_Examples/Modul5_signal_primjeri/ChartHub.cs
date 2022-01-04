using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIT_Api_Examples.Modul5_signal_primjeri
{
    public class ChartHub : Hub
    {
        public async Task MetodaHub1(object data)
        {
            //zamjena za controler/akciju
            Console.WriteLine("poruka MetodaHub1: " + data);
        }
    }
}
