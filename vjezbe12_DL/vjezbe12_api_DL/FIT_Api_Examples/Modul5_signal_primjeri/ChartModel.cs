using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIT_Api_Examples.Modul5_signal_primjeri
{
    public class ChartModel
    {
        public List<int> data { get; set; }
        public string label { get; set; }
        public ChartModel()
        {
            data = new List<int>();
        }
    }
}
