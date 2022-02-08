using System;
using System.Collections.Generic;
using PsyApp.ViewModel;
using Xamarin.Forms;

namespace PsyApp.View
{
    public partial class PsychonautsPage : ContentPage
    {
        private readonly PsychonautsPageViewModel ViewModel;

        public PsychonautsPage()
        {
            InitializeComponent();

            ViewModel = new PsychonautsPageViewModel();
            BindingContext = ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ViewModel.PopulateCharactersList();
        }
    }
}
