using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageDostavkaAddressViewModel : BaseViewModel
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

        public PageDostavkaAddressViewModel()
        {
            MessagingCenter.Subscribe<CustomAddress>(this, Strings.SELECT_ADDRESS, sender => {
                SelectedAddress = sender;
            });
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
                MessagingCenter.Send<BaseViewModel, string>(this, Strings.SELECT_DOSTAVKA_ADDRESS, (SelectedAddress.BindingContext as CustomAddressViewModel).FullAddress);
            });
        }
    }
}
