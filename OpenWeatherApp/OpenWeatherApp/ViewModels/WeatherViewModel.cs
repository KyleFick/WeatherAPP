using OpenWeatherApp.Models;
using OpenWeatherApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp.ViewModels
{
    
    
        public class WeatherViewModel
        {
            private IList<OneCallAPI> _weatherList;
            public IList<OneCallAPI> WeatherList
            {
                get
                {
                    if (_weatherList == null)
                        _weatherList = new ObservableCollection<OneCallAPI>();
                    return _weatherList;
                }
                set
                {
                    _weatherList = value;
                }
            }

            private async Task APIAsync()
            {
                var weather = await WeatherAPI.GetOneCallAPIAsync(-26.120134, 27.901464, "metric");
                //    var weather = await WeatherAPI.GetFiveDaysAsync("Roodepoort");
                WeatherList.Add(weather);
            }

            public WeatherViewModel()
            {
                Task.Run(APIAsync);
            }
        }
    
    
}
