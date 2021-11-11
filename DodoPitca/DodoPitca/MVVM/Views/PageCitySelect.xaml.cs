using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            MessagingCenter.Subscribe<BaseViewModel>(this, Strings.FOCUS_SEARCHBOX, obj =>
              {
                  searchBox.Focus();
              });
            (BindingContext as PageCitySelectViewModel).CurrentCity = stackCities.Children.Where(item => (item as CustomCity).Title == title).First() as CustomCity;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex reg = new Regex("^" + (BindingContext as PageCitySelectViewModel).SearchPattern + @"\D*", RegexOptions.IgnoreCase);
            foreach(CustomCity item in stackCities.Children)
            {
                if (reg.IsMatch((item.BindingContext as CustomCityViewModel).Title))
                    item.IsVisible = true;
                else
                    item.IsVisible = false;
            }
        }
    }
}