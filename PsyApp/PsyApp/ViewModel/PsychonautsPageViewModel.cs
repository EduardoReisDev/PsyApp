using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PsyApp.Constant;
using PsyApp.Model;

namespace PsyApp.ViewModel
{
    public class PsychonautsPageViewModel : BaseViewModel
    {
        public ObservableCollection<Power> PowersList { get; set; }
        public ObservableCollection<Character> CharactersList { get; set; }

        public PsychonautsPageViewModel()
        {
            PowersList = new ObservableCollection<Power>();
            CharactersList = new ObservableCollection<Character>();
        }

        public void PopulateCharactersList()
        {
            var httpClient = new HttpClient();
            var content = httpClient.GetStringAsync(Constants.GetCaracters).Result;
            var CaractersList = JsonConvert.DeserializeObject<Character>(content);


        }

        public void PopulatePowersList()
        {

        }
    }
}
