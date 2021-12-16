using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageDostavkaAddress2ViewModel: BaseViewModel
    {
        public ObservableCollection<DostavkaAddress> Addresses { get; set; }
        public ICommand CommandBack { get; }

        public PageDostavkaAddress2ViewModel()
        {
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
            Addresses = new ObservableCollection<DostavkaAddress>();
            foreach(var element in DostavkaAddresses.addresses)
            {
                Addresses.Add(element);
            }
        }
    }
}
