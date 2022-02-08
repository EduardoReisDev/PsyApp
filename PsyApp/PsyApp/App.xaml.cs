using PsyApp.View;
using Xamarin.Forms;

namespace PsyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PsychonautsPage();
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
