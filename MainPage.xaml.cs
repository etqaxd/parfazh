using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System;
using Microsoft.Maui.Controls;

namespace parfazh
{
    public partial class MainPage : ContentPage
    {
        private bool isPageOpen = false;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTestClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string url = "http://www.pdd24.com";
            await Launcher.OpenAsync(url);
        }

        private async void OnRegistartionClicked(object sender, EventArgs e)
        {
            if (!isPageOpen)
            {
                isPageOpen = true;
                var newPage = new RegistrationPage();
                newPage.Disappearing += (s, args) => isPageOpen = false;
                await Navigation.PushAsync(newPage);
            }
        }

        private async void OnChatClicked(object sender, EventArgs e)
        {
            if (!isPageOpen)
            {
                isPageOpen = true;
                var newChatPage = new ChatPage();
                newChatPage.Disappearing += (s, args) => isPageOpen = false;
                await Navigation.PushAsync(newChatPage);
            }


        }

    }
} 
