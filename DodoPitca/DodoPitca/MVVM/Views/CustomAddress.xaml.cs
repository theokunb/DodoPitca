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
    public partial class CustomAddress : ContentView
    {
        public CustomAddress(Address address)
        {
            InitializeComponent();
            if (address.GetType().Equals(typeof(DostavkaAddress)))
            {
                (BindingContext as CustomAddressViewModel).FullAddress = (address as DostavkaAddress).Address;
                (BindingContext as CustomAddressViewModel).Comment = (address as DostavkaAddress).Comment;
            }
            else if(address.GetType().Equals(typeof(RestoranAddress)))
            {
                (BindingContext as CustomAddressViewModel).FullAddress = (address as RestoranAddress).Address;
                (BindingContext as CustomAddressViewModel).Comment = (address as RestoranAddress).WorkTime;
            }
        }
    }
}