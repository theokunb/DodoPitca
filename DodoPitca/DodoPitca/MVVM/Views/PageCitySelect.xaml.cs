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
    public partial class PageCitySelect : ContentPage
    {
        public PageCitySelect(string title)
        {
            InitializeComponent();
            (BindingContext as PageCitySelectViewModel).CurrentCity = stackCities.Children.Where(item => (item as CustomCity).Title == title).First() as CustomCity;
        }
    }
}