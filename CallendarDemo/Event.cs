using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallendarDemo
{
    public class Event
    {
        public int id { get; set; }
        public string event_name { get; set; }
        public DateTime event_date { get; set; }
        public TimeSpan event_time { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ event_name } { event_time }";
            }
        }

    }
}
