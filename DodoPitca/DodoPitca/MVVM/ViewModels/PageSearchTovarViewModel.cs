using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageSearchTovarViewModel:BaseViewModel
    {
        private string searchPattern;
        private bool isSearchMode = false;


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
