using System;
using System.Threading.Tasks;
using PsyApp.Model;
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

            CharactersCollection.SelectionChanged += SelectedCharacterAsync;
        }

        private async void SelectedCharacterAsync(object sender, SelectionChangedEventArgs e)
        {
            string selectedCharacterName = ((sender as CollectionView).SelectedItem as Character).Name;
            await Navigation.PushAsync(new CharacterPage(GetCharacterFirstName(selectedCharacterName)));
        }

        private string GetCharacterFirstName(string selectedCharacterName)
        {
            int spaceIndex = selectedCharacterName.IndexOf(" ");
            return selectedCharacterName.Substring(0, spaceIndex);
        }
    }
}
