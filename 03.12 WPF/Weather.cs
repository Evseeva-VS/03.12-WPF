using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12_WPF
{
    // Класс данных
    public class Weather
    {
        public DateTime now { get; set; }
        public Info info { get; set; }
        public int temp { get; set; }
        public int feels_like { get; set; }
        public string condition { get; set; }
        public string season { get; set; }
    }
    public class Info
    {
        public float lat { get; set; }
        public float lon { get; set; }
        public TZInfo tzinfo { get; set; }

    }
    public class TZInfo
    {
        public string name { get; set; }
        public string abbr { get; set; }
        public bool dst { get; set; }
    }
}
