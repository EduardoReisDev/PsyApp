using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using PsyApp.Constant;
using PsyApp.Model;

namespace PsyApp.ViewModel
{
    public class PsychonautsPageViewModel : BaseViewModel
    {
        public ObservableCollection<Character> CharactersList { get; set; }
        public ObservableCollection<Power> PowersList { get; set; }

        private readonly HttpClient httpClient;

        public PsychonautsPageViewModel()
        {
            httpClient = new HttpClient();
            
            PowersList = new ObservableCollection<Power>();
            CharactersList = new ObservableCollection<Character>();
        }

        public void PopulateCharactersList()
        {
            CharactersList = RetrieveAllCharacters();
        }

        public void PopulatePowersList()
        {
            PowersList = RetrieveAllPowers();
        }

        private ObservableCollection<Character> RetrieveAllCharacters()
        {
            var charactersSerialized = httpClient.GetStringAsync(Constants.CaractersURL).Result;
            var charactersDeserialized = JsonConvert.DeserializeObject<List<Character>>(charactersSerialized);

            ObservableCollection<Character> allCharacters = new(charactersDeserialized);

            return allCharacters;
        }

        private ObservableCollection<Power> RetrieveAllPowers()
        {
            var powersSerialized = httpClient.GetStringAsync(Constants.PowersURL).Result;
            var powersDeserialized = JsonConvert.DeserializeObject<List<Power>>(powersSerialized);

            ObservableCollection<Power> allPowers = new(powersDeserialized);

            return allPowers;
        }
    }
}
