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
        public static readonly BindableProperty ModeProperty = BindableProperty.Create(nameof(Mode),typeof(Mode),typeof(CustomToggleBotton),Mode.Second,BindingMode.TwoWay,propertyChanged:ModePropertyChanged);
        public static readonly BindableProperty FirstTextProperty = BindableProperty.Create(nameof(FirstText),typeof(string),typeof(CustomToggleBotton),"",BindingMode.TwoWay,propertyChanged:FirstTextPropertyChanged);
        public static readonly BindableProperty SecondTextProperty = BindableProperty.Create(nameof(SecondText),typeof(string),typeof(CustomToggleBotton),"",BindingMode.TwoWay,propertyChanged:SecondTextPropertyChanged);

        private static void SecondTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable.BindingContext as CustomToggleBottonViewModel).SecondText = newValue.ToString();
        }

        private static void FirstTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable.BindingContext as CustomToggleBottonViewModel).FirstText = newValue.ToString();
        }

        private static void ModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomToggleBotton)bindable;
            var controlVM = control.BindingContext as CustomToggleBottonViewModel;
            controlVM.Mode = (Mode)newValue;
            control.SliderMoveTo(controlVM.Mode);
        }


        public string FirstText
        {
            get { return GetValue(FirstTextProperty).ToString(); }
            set { SetValue(FirstTextProperty, value); }
        }
        public string SecondText
        {
            get { return GetValue(SecondTextProperty).ToString(); }
            set { SetValue(SecondTextProperty, value); }
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
            if(mode == Mode.First)
                Slider.TranslateTo(0, 0);
            else if(mode == Mode.Second)
                Slider.TranslateTo(baseRect.Width / 2, 0);
        }
    }
}