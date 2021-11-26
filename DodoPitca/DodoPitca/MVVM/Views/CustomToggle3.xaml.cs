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
    public partial class CustomToggle3 : ContentView
    {
        public static readonly BindableProperty FirstTextProperty = BindableProperty.Create(nameof(FirstText),typeof(string),typeof(CustomToggle3),string.Empty,BindingMode.TwoWay,propertyChanged:FirstTextPropertyChanged);
        public static readonly BindableProperty SecondTextProperty = BindableProperty.Create(nameof(SecondText),typeof(string),typeof(CustomToggle3),string.Empty,BindingMode.TwoWay,propertyChanged:SecondTextPropertyChanged);
        public static readonly BindableProperty ThirdTextProperty = BindableProperty.Create(nameof(ThirdText),typeof(string),typeof(CustomToggle3),string.Empty,BindingMode.TwoWay,propertyChanged:ThirdTextPropertyChanged);
        public static readonly BindableProperty ModeProperty = BindableProperty.Create(nameof(Mode),typeof(Mode3),typeof(CustomToggle3),Mode3.First,BindingMode.TwoWay,propertyChanged:ModePropertyChanged);


        private static void ThirdTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomToggle3ViewModel;
            controlVM.ThirdText = newValue.ToString();
        }

        private static void FirstTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomToggle3ViewModel;
            controlVM.FirstText = newValue.ToString();
        }
        private static void SecondTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomToggle3ViewModel;
            controlVM.SecondText = newValue.ToString();
        }
        private static void ModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomToggle3)bindable;
            var controlVM = bindable.BindingContext as CustomToggle3ViewModel;
            controlVM.Mode = (Mode3)newValue;
            control.SliderMoveTo(controlVM.Mode);
        }

        public Mode3 Mode
        {
            get { return (Mode3)GetValue(ModeProperty); }
            set 
            {
                SetValue(ModeProperty, value);
                SliderMoveTo(Mode);
            }
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
        public string ThirdText
        {
            get { return GetValue(ThirdTextProperty).ToString(); }
            set { SetValue(ThirdTextProperty, value); }
        }
        public CustomToggle3()
        {
            InitializeComponent();
        }
        private void SliderMoveTo(Mode3 mode)
        {
            if (mode == Mode3.First)
                slider.TranslateTo(0, 0);
            else if (mode == Mode3.Second)
                slider.TranslateTo(baseRect.Width / 3, 0);
            else
                slider.TranslateTo(2 * baseRect.Width / 3, 0);
        }

    }
}