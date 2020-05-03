using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallendarDemo
{
    public class WeatherResultsModel
    {
        public List<WeatherModel> Weather { get; set; }
        public MainModel Main { get; set; }
    }
}
