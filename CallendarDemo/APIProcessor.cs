using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CallendarDemo
{
    public class APIProcessor
    {
        public static async Task<WeatherResultsModel> LoadWeatherIcon(string city) 
        {
           
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=e773840128f3efcebd9d27539ab44722", city);
            
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode) //check if we are connected
                {
                    WeatherResultsModel weather = await response.Content.ReadAsAsync<WeatherResultsModel>(); // read from JSON only elements which are in class
                    
                    return weather;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }


    }
        
    }

