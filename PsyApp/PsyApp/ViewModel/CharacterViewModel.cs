using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using PsyApp.Constant;
using PsyApp.Model;

namespace PsyApp.ViewModel
{
    public class CharacterViewModel : BaseViewModel
    {
        public ObservableCollection<Power> PowersList { get; set; }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }

        public Uri Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        private readonly string characterName;
        private string name;
        private string gender;
        private Uri image;

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

            FillThePowerList(character);
        }

        private Character GetCharacter()
        {
            HttpClient httpClient = new();
            var characterSerialized = httpClient.GetStringAsync(Constants.CaractersURL + "?name=" + characterName).Result;
            return JsonConvert.DeserializeObject<Character>(characterSerialized);
        }

        private void FillThePowerList(Character character)
        {
            List<Power> powersList = new();
            powersList.AddRange(character.Powers);
            PowersList = new ObservableCollection<Power>();

            foreach (Power power in powersList)
            {
                PowersList.Add(power);
            }
        }
    }
}
