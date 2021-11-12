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
    public partial class PageSearchTovar : ContentPage
    {
        private IList<View> tovars;
        public PageSearchTovar(IList<View> views)
        {
            InitializeComponent();
            tovars = views;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            stackTovars.Children.Clear();
            Regex reg = new Regex("^" + (BindingContext as PageSearchTovarViewModel).SearchPattern + @"\S+$");
            for(int i = 0; i < tovars.Count; i++)
            {
                if (reg.IsMatch((tovars[i] as CustomTovar).Title))
                    stackTovars.Children.Add(tovars[i]);
            }
        }
    }
}