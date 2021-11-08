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
    public partial class CustomButton : ContentView
    {
        public static readonly BindableProperty CityIndexProperty = BindableProperty.Create(nameof(CityIndex), typeof(int), typeof(CustomButton), 0, BindingMode.TwoWay, propertyChanged: CityIndexPropertyChanged);

        private static void CityIndexPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomButton)bindable;
            var controlVM = control.BindingContext as CustomButtonViewModel;
            controlVM.CurrentCity = (Models.City)newValue;
        }

        public int CityIndex
        {
            get { return Convert.ToInt32(GetValue(CityIndexProperty)); }
            set { SetValue(CityIndexProperty, value); }
        }


        public CustomButton()
        {
            InitializeComponent();
        }
    }
}