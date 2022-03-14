using PsyApp.View;
using Xamarin.Forms;

namespace PsyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Sharpnado.MaterialFrame.Initializer.Initialize(loggerEnable: false, debugLogEnable: false);

            MainPage = new NavigationPage(new PsychonautsPage());
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
