using PsyApp.ViewModel;
using Xamarin.Forms;

namespace PsyApp.View
{
    public partial class PsychonautsPage : ContentPage
    {
        private readonly PsychonautsPageViewModel viewModel;

        public PsychonautsPage()
        {
            InitializeComponent();

            viewModel = new PsychonautsPageViewModel();
            BindingContext = viewModel;

            viewModel.PopulateCharactersList();
            viewModel.PopulatePowersList();
        }
    }
}
