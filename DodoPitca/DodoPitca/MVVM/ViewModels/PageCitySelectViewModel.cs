using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageCitySelectViewModel : BaseViewModel
    {
        private CustomCity currentCity;

        public CustomCity CurrentCity
        {
            get => currentCity;
            set
            {
                if (currentCity != null)
                    currentCity.IsChecked = false;
                value.IsChecked = true;
                currentCity = value;
                OnpropertyChagned();
            }
        }

        public ICommand CommandExit { get; }
        public ICommand CommandSetCity { get; }
        public PageCitySelectViewModel()
        {
            MessagingCenter.Subscribe<BaseViewModel, CustomCity>(this, Strings.SELECT_CITY, (obj, param) =>
            {
                CurrentCity = param;
            });
            CommandExit = new Command(async o =>
            {
                MessagingCenter.Send<BaseViewModel, string>(this, Strings.SET_CITY, CurrentCity.Title);
                await Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
    }
}
