using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using PsyApp.Constant;
using PsyApp.Model;

namespace PsyApp.ViewModel
{
    public class CharacterViewModel
    {
        public ObservableCollection<Power> PowersList { get; set; } = new ObservableCollection<Power>();
        public string Name { get; set; }
        public string Gender { get; set; }
        public Uri Image { get; set; }

        private readonly string characterName;

        public CharacterViewModel(string characterName)
        {
            this.characterName = characterName;
        }

        public void SetCharacterInfo()
        {
            Character character = GetCharacter();

            Name = character.Name;
            Gender = character.Gender;
            Image = character.Img;

            //FillThePowerList(character);
        }

        private Character GetCharacter()
        {
            HttpClient httpClient = new();
            var characterSerialized = httpClient.GetStringAsync(Constants.CaractersURL + "?name=" + characterName).Result;
            return JsonConvert.DeserializeObject<Character>(characterSerialized);
        }

        private void FillThePowerList(Character character)
        {
            foreach (Power power in character.Powers)
            {
                PowersList.Add(power);
            }
        }
    }
}
