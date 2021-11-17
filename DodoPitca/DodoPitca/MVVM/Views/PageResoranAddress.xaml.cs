using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DodoPitca.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageResoranAddress : ContentPage
    {
        private readonly string currentAddress;

        public PageResoranAddress(string address)
        {
            currentAddress = address;
            InitializeComponent();
            LoadAddresses();
        }

        private void LoadAddresses()
        {
            foreach(var element in RestoranAddresses.addresses)
            {
                stackAddresses.Children.Add(new CustomAddress(element));
                if(element.Address == currentAddress)
                {
                    (BindingContext as PageRestoranAddressViewModel).SelectedAddress = stackAddresses.Children.Last() as CustomAddress;
                }
            }
        }
    }
}