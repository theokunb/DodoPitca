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
    public partial class PageTovarView : ContentPage
    {
        public PageTovarView(Zakuska selectedItem)
        {
            InitializeComponent();
            (BindingContext as PageTovarViewModel).SelectedId = selectedItem.Id;
            (BindingContext as PageTovarViewModel).Tovars.Add(selectedItem);
        }
        public PageTovarView(Zakuska selectedItem,IEnumerable<Tovar> collection)
        {
            InitializeComponent();
            int id = 0;
            foreach (var item in collection)
            {
                if (selectedItem == item)
                    (BindingContext as PageTovarViewModel).SelectedId = id;
                (BindingContext as PageTovarViewModel).Tovars.Add(item);
                id++;
            }
        }
    }
}