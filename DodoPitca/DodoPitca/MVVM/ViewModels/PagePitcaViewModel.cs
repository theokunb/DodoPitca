using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PagePitcaViewModel : Pitca
    {
        public ICommand CommandBack { get; }
        public PagePitcaViewModel()
        {
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
    }
}
