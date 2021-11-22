using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageSearchTovarViewModel:BaseViewModel
    {
        private string searchPattern;
        private bool isSearchMode = false;
        public ObservableCollection<CustomTovarViewModel> DisplayTovars { get; set; }
        public ObservableCollection<CustomTovarViewModel> Tovars { get; set; }
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
        public bool IsSearchMode
        {
            get => isSearchMode;
            set
            {
                if (!isSearchMode)
                {
                    isSearchMode = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandClear { get; }
        public ICommand CommandBack { get; }
        public PageSearchTovarViewModel()
        {
            DisplayTovars = new ObservableCollection<CustomTovarViewModel>();
            MessagingCenter.Subscribe<BaseViewModel, ObservableCollection<CustomTovarViewModel>>(this, Strings.FIND_TOVARS, (sender, param) =>
            {
                Tovars = param;
            });
            CommandBack = new Command(async param =>
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            });
            CommandClear = new Command(param =>
            {
                SearchPattern = string.Empty;
            });
            
        }

    }
}
