using OpenWeatherApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;
using Image = Xamarin.Forms.Image;

namespace OpenWeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {

        public WeatherPage()
        {
            InitializeComponent();
            this.BindingContext = new WeatherViewModel();


            Title = "WeatherPage";
            BackgroundColor = Color.DodgerBlue;

       
        }


    }

   
}