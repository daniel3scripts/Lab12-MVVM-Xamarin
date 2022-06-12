using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab12MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.Calculator();
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
