using prak_6_2_Forrat.Services;
using prak_6_2_Forrat.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prak_6_2_Forrat
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
           
            DependencyService.Register<MockDataStore>();
            MainPage =new NavigationPage( new Calculator());
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
