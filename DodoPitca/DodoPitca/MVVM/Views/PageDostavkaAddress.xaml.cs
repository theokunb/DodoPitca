using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DodoPitca.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDostavkaAddress : ContentPage
    {
        private readonly string currentAddres;

        public PageDostavkaAddress(string address)
        {
            currentAddres = address;
            InitializeComponent();
            LoadAddresses();
        }

        private void LoadAddresses()
        {
            foreach(var element in DostavkaAddresses.addresses)
            {
                stackAddresses.Children.Add(new CustomAddress(element));
                if(element.Address == currentAddres)
                {
                    (BindingContext as PageDostavkaAddressViewModel).SelectedAddress = stackAddresses.Children.Last() as CustomAddress;
                }
            }
        }
    }
}