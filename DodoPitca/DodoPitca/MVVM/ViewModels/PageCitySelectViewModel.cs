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
        private bool isSearching = false;
        private CustomCity currentCity;
        private string searchPattern = string.Empty;


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
        public bool IsSearching
        {
            get => isSearching;
            set
            {
                if(isSearching!=value)
                {
                    isSearching = value;
                    OnpropertyChagned();
                }
            }
        }
        public string SearchPattern
        {
            get => searchPattern;
            set
            {
                if (searchPattern != value)
                {
                    searchPattern = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandSearch { get; }
        public ICommand CommandExit { get; }
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
            CommandSearch = new Command(param =>
            {
                IsSearching = !IsSearching;
                if (!IsSearching)
                {
                    SearchPattern = string.Empty;
                }
                else
                {
                    MessagingCenter.Send<BaseViewModel>(this, Strings.FOCUS_SEARCHBOX);
                }
            });
        }
    }
}
