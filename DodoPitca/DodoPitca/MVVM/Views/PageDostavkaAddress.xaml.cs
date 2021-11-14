using DodoPitca.MVVM.Models;
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
    public partial class PageDostavkaAddress : ContentPage
    {
        public PageDostavkaAddress()
        {
            InitializeComponent();
            F();
        }

        private async void F()
        {
            for (int i = 0; i < DostavkaAddresses.addresses.Count; i++)
            {
                Task<CustomAddress> addressesTask = LoadAddreses(i);
                stackAddresses.Children.Add(await addressesTask);
            }
        }

        private async Task<CustomAddress> LoadAddreses(int index)
        {
            await Task.Delay(5);
            return new CustomAddress(DostavkaAddresses.addresses[index]);
        }
    }
}