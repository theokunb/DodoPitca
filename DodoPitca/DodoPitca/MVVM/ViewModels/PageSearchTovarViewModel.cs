using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageSearchTovarViewModel:BaseViewModel
    {
        private string searchPattern;
        private bool isSearchMode = false;
        public ObservableCollection<Tovar> DisplayTovars { get; set; }
        public ObservableCollection<Tovar> Tovars { get; set; }
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
        public ICommand CommandViewTovar { get; }
        public PageSearchTovarViewModel()
        {
            DisplayTovars = new ObservableCollection<Tovar>();
            MessagingCenter.Subscribe<BaseViewModel, ObservableCollection<Tovar>>(this, Strings.FIND_TOVARS, (sender, param) =>
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
            CommandViewTovar = new Command(param =>
            {
                if (int.TryParse(param.ToString(), out int id))
                {
                    var selectedItem = DisplayTovars.First(item => item.Id == id);
                    if (selectedItem.GetType() == typeof(Pitca))
                    {
                        Application.Current.MainPage.Navigation.PushModalAsync(new PagePitcaView(selectedItem as Pitca));
                    }
                }
            });
        }

    }
}
