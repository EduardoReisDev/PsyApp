using PsyApp.ViewModel;
using Xamarin.Forms;

namespace PsyApp.View
{
    public partial class CharacterPage : ContentPage
    {
        private readonly CharacterViewModel viewModel;

        public CharacterPage(string characterName)
        {
            InitializeComponent();

            viewModel = new CharacterViewModel(characterName);
            BindingContext = viewModel;

            viewModel.SetCharacterInfo();
        }
    }
}
