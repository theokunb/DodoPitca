using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageTovarViewModel:BaseViewModel
    {
        private int selectedId;

        public ObservableCollection<Tovar> Tovars { get; set; } 
        public int SelectedId
        {
            get => selectedId;
            set
            {
                if (selectedId != value)
                {
                    selectedId = value;
                    OnpropertyChagned();
                }
            }
        }

        public ICommand CommandBack { get; }

        public PageTovarViewModel()
        {
            Tovars = new ObservableCollection<Tovar>();
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
    }
}
