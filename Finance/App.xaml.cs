using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Finance.View;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Finance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            string androidAppSecret = "e92cb974-cb34-4766-b92d-f4c0ad666f50";
            string iOSAppSecret = "fc1cd97a-fa60-4e29-a745-645fbdba754f";
            AppCenter.Start($"android={androidAppSecret};ios={iOSAppSecret}", typeof(Crashes), typeof(Analytics));

            bool didAppCrashed = await Crashes.HasCrashedInLastSessionAsync();
            if (didAppCrashed)
            {
                var crashReport = await Crashes.GetLastSessionCrashReportAsync();
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
