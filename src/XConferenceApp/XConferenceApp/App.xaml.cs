using Xamarin.Forms;
using XConferenceApp.Resources;
using XConferenceApp.Shells;
using XConferenceApp.Views;

namespace XConferenceApp
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShellFlyout();
        }

        protected override void OnStart()
        {
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(RouteConfig.SpeakerDetailSingle, typeof(SpeakerDetailView));
            Routing.RegisterRoute(RouteConfig.SpeakerDetailHierarchy, typeof(SpeakerDetailView));

            Routing.RegisterRoute(RouteConfig.SessionDetailSingle, typeof(SessionDetailView));
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
