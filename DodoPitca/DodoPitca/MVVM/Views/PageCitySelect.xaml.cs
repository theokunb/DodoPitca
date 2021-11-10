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
            foreach (CustomCity item in stackCities.Children)
            {
                if (item.Title == title)
                    (BindingContext as PageCitySelectViewModel).CurrentCity = item;
            }
        }
    }
}