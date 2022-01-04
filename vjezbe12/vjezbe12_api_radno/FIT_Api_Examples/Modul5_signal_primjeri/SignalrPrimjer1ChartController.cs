using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using FIT_Api_Examples.Data;
using FIT_Api_Examples.Helper;
using FIT_Api_Examples.Helper.AutentifikacijaAutorizacija;
using FIT_Api_Examples.Modul2.Models;
using FIT_Api_Examples.Modul3.Models;
using FIT_Api_Examples.Modul4_MaticnaKnjiga.Models;
using FIT_Api_Examples.Modul4_MaticnaKnjiga.ViewModels;
using FIT_Api_Examples.Modul5_signal_primjeri;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace FIT_Api_Examples.Modul4_MaticnaKnjiga.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class SignalrPrimjer1ChartController : ControllerBase
    {
        private IHubContext<ChartHub> _hub;

        public SignalrPrimjer1ChartController(IHubContext<ChartHub> hub)
        {
            _hub = hub;
        }

        [HttpPost]
        public IActionResult ApiPosaljiPodatke(int a, int b, int c, int d)
        {
            PosaljiPodatkePremaKlijentuPrekoWS(a, b, c, d);

            return Ok();
        }

        [HttpPost]
        public IActionResult TimerPokreni()
        {
            var timer = new Timer((state) =>
            {
                Random r = new Random();
                PosaljiPodatkePremaKlijentuPrekoWS(r.Next(), r.Next(), r.Next(), r.Next());
            });
            timer.Change(0, 100);
            return Ok();
        }

        private void PosaljiPodatkePremaKlijentuPrekoWS(int a, int b, int c, int d)
        {
            var podaci = new List<ChartModel>
            {
                new ChartModel(){data = new List<int>(){a}, label = "Kolona 1"},
                new ChartModel(){data = new List<int>(){b}, label = "Kolona 2"},
                new ChartModel(){data = new List<int>(){c}, label = "Kolona 3"},
                new ChartModel(){data = new List<int>(){d}, label = "Kolona 4"},
            };
            _hub.Clients.All.SendAsync("transferchartdata", podaci);
        }
    }
}
