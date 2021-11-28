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
    public partial class PagePitcaView : ContentPage
    {
        public PagePitcaView(Pitca selectedItem)
        {
            InitializeComponent();
            (BindingContext as PagePitcaViewModel).SelectedId = 0;
            (BindingContext as PagePitcaViewModel).Pitci.Add(selectedItem);
        }
        public PagePitcaView(Pitca selectedItem,IEnumerable<Tovar> items)
        {
            InitializeComponent();
            int id = 0;
            foreach (var item in items)
            {
                if (selectedItem == item)
                    (BindingContext as PagePitcaViewModel).SelectedId = id;
                (BindingContext as PagePitcaViewModel).Pitci.Add(item as Pitca);
                id++;
            }
              
        }
    }
}