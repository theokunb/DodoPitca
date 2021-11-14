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
    public partial class CustomToggleBotton : ContentView
    {
        public static readonly BindableProperty ModeProperty = BindableProperty.Create(nameof(Mode),typeof(Mode),typeof(CustomToggleBotton),Mode.Restoran,BindingMode.TwoWay,propertyChanged:ModePropertyChanged);

        private static void ModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomToggleBotton)bindable;
            var controlVM = control.BindingContext as CustomToggleBottonViewModel;
            controlVM.Mode = (Mode)newValue;
            control.SliderMoveTo(controlVM.Mode);
        }

        public Mode Mode
        {
            get { return (Mode)GetValue(ModeProperty);}
            set 
            {
                SetValue(ModeProperty, value);
                SliderMoveTo(Mode);
            }
        }

        public CustomToggleBotton()
        {
            InitializeComponent();
        }

        private void SliderMoveTo(Mode mode)
        {
            if(mode == Mode.Dostavka)
                Slider.TranslateTo(0, 0);
            else if(mode == Mode.Restoran)
                Slider.TranslateTo(baseRect.Width / 2, 0);
        }
    }
}