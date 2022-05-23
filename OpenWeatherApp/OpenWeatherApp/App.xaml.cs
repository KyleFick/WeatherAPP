using OpenWeatherApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("PermanentMarker-Regular.ttf", Alias = "CustomFont")]
namespace OpenWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
