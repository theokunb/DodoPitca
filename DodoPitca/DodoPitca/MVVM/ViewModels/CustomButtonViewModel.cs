using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomButtonViewModel : BaseViewModel
    {
        private string cityTitle;
        
        public string CityTitle
        {
            get => cityTitle;
            set
            {
                if (cityTitle == value)
                    return;
                cityTitle = value;
                OnpropertyChagned();
            }
        }
        public ICommand CommandSelectCity { get; }
        public CustomButtonViewModel()
        {
            CommandSelectCity = new Command(async param =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new PageCitySelect());
            });
        }
    }
}
