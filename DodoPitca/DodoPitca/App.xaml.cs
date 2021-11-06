﻿using DodoPitca.MVVM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DodoPitca
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageMain();
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
