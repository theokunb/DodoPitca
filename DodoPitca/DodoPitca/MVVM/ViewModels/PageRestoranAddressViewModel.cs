using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageRestoranAddressViewModel : BaseViewModel
    {
        private CustomAddress selectedAddress;
        public CustomAddress SelectedAddress
        {
            get => selectedAddress;
            set
            {
                if (selectedAddress != null)
                    selectedAddress.IsSelected = false;
                selectedAddress = value;
                selectedAddress.IsSelected = true;
                OnpropertyChagned();
            }
        }
        public ICommand CommandBack { get; }


        public PageRestoranAddressViewModel()
        {
            MessagingCenter.Subscribe<CustomAddress>(this, Strings.SELECT_ADDRESS, sender => {
                SelectedAddress = sender;
            });
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
                MessagingCenter.Send<BaseViewModel, string>(this, Strings.SELECT_RESTORAN_ADDRESS, (SelectedAddress.BindingContext as CustomAddressViewModel).FullAddress);
                MessagingCenter.Unsubscribe<CustomAddress>(this, Strings.SELECT_ADDRESS);
            });
        }
    }
}
