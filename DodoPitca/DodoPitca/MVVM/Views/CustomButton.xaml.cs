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
        public static readonly BindableProperty CityTitleProperty = BindableProperty.Create(nameof(CityTitle), typeof(string), typeof(CustomButton), "", BindingMode.TwoWay, propertyChanged: CityTitlePropertyChanged);


        public string CityTitle
        {
            get { return GetValue(CityTitleProperty).ToString(); }
            set { SetValue(CityTitleProperty, value); }
        }
        private static void CityTitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
                return;
            var control = (CustomButton)bindable;
            var controlVM = control.BindingContext as CustomButtonViewModel;
            controlVM.CityTitle = newValue.ToString();
        }

        public CustomButton()
        {
            InitializeComponent();
        }
    }
}