using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Resources;

namespace CallendarDemo
{
    public partial class Dashboard : Form
    {
        List<Event> events = new List<Event>();
        string cityName = "wroclaw";
        
        public Dashboard()
        {
            InitializeComponent();

            EventsListBox.DataSource = events;
            EventsListBox.DisplayMember = "FullInfo";
            WeatherLabel.Text = "TODAY'S WEATHER IN " + cityName.ToUpper();

            APIHelper.InitializeClient();
        }


        private async Task LoadWeatherImage(string cityName)
        {
            var weather = await APIProcessor.LoadWeatherIcon(cityName);
            string path = string.Format("http://openweathermap.org/img/wn/{0}@2x.png", weather.Weather[0].icon);
            WeatherImage.Load(path);
            int temperature = Convert.ToInt32(weather.Main.Temp - 273.15);

            DegreeLabel.Text = temperature.ToString()+ "°C";
        }


        private void UpdateBinding()
        {
            EventsListBox.DataSource = events;
            EventsListBox.DisplayMember = "FullInfo";
        }


        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            events = db.GetEvents(Calendar.SelectionRange.Start);
            UpdateBinding();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int hour = Convert.ToInt32(numericHour.Value);
            int min = Convert.ToInt32(numericMin.Value);
            TimeSpan ts = new TimeSpan(hour, min, 0);
            db.InsertEvent(Calendar.SelectionRange.Start, EventNameText.Text, ts);

            EventNameText.Text = "";
        }


        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await LoadWeatherImage(cityName);
        }

        private async void CityButton_Click(object sender, EventArgs e)
        {
            cityName = CityTextBox.Text.ToLower();
            WeatherLabel.Text = "TODAY'S WEATHER IN " + cityName.ToUpper();
            await LoadWeatherImage(cityName);
        }


    }
}
