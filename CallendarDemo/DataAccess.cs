using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CallendarDemo
{
    public class DataAccess
    {
        public List<Event> GetEvents(DateTime date)
        {
            string sqlFormattedDate = date.ToString("yyyy-MM-dd");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EventsDB"))) //gives us connection string
            {
              // var output = connection.Query<Event>($"select * from Event_table where event_date = '{ sqlFormattedDate }'").ToList();
               var output = connection.Query<Event>("dbo.spEvents_GetByDate @event_date", new { event_date = sqlFormattedDate }).ToList(); //using store procedure
                return output;
            }
        }

        internal void InsertEvent(DateTime date, string name, TimeSpan time)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EventsDB"))) //gives us connection string
            {
                List<Event> ev = new List<Event>();
                ev.Add(new Event { event_date = date, event_name = name, event_time = time });
                connection.Execute("dbo.spEvent_Insert @event_name, @event_date, @event_time", ev);
            }
        }
    }
}
