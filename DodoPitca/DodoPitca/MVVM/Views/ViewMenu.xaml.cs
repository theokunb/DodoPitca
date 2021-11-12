﻿using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DodoPitca.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewMenu : ContentView
    {
        public ViewMenu()
        {
            InitializeComponent();
        }

        private void SearchTovar_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new PageSearchTovar(stackTovars.Children));
        }
    }
}