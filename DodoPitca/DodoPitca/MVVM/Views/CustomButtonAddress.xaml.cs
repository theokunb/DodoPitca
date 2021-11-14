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
    public partial class CustomButtonAddress : ContentView
    {
        public static readonly BindableProperty ImageDostavkaProperty = BindableProperty.Create(nameof(ImageDostavka),typeof(ImageSource),typeof(CustomButtonAddress),null,BindingMode.TwoWay,propertyChanged:ImageDostavkaPropertyChanged);
        public static readonly BindableProperty ImageRestoranProperty = BindableProperty.Create(nameof(ImageRestoran), typeof(ImageSource), typeof(CustomButtonAddress), null, BindingMode.TwoWay,propertyChanged:ImageRestoranPropertyChanged);
        public static readonly BindableProperty ModeProperty = BindableProperty.Create(nameof(Mode),typeof(Mode),typeof(CustomButtonAddress),Mode.Dostavka,BindingMode.TwoWay,propertyChanged:ModePropertyChanged);
        public static readonly BindableProperty TextDostavkaProperty = BindableProperty.Create(nameof(TextDostavka), typeof(string), typeof(CustomButtonAddress), string.Empty, BindingMode.TwoWay, propertyChanged: TextDostavkaPropertyChanged);
        public static readonly BindableProperty TextRestoranProperty = BindableProperty.Create(nameof(TextRestoran), typeof(string), typeof(CustomButtonAddress), string.Empty, BindingMode.TwoWay, propertyChanged: TextRestoranPropertyChanged);

        
        public string TextDostavka
        {
            get { return GetValue(TextDostavkaProperty).ToString(); }
            set { SetValue(TextDostavkaProperty, value); }
        }
        public string TextRestoran
        {
            get { return GetValue(TextRestoranProperty).ToString(); }
            set { SetValue(TextRestoranProperty, value); }
        }
        public Mode Mode
        {
            get { return (Mode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }
        public ImageSource ImageDostavka
        {
            get { return (ImageSource)GetValue(ImageDostavkaProperty); }
            set { SetValue(ImageDostavkaProperty, value); }
        }
        public ImageSource ImageRestoran
        {
            get { return (ImageSource)GetValue(ImageRestoranProperty); }
            set { SetValue(ImageRestoranProperty, value); }
        }


        private static void TextRestoranPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomButtonAddress)bindable;
            var controlVM = control.BindingContext as CustomButtonAddressViewModel;
            controlVM.TextRestoran = newValue.ToString();
        }

        private static void TextDostavkaPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomButtonAddress)bindable;
            var controlVM = control.BindingContext as CustomButtonAddressViewModel;
            controlVM.TextDostavka = newValue.ToString();
        }

        private static void ModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomButtonAddress)bindable;
            var controlVM = control.BindingContext as CustomButtonAddressViewModel;
            controlVM.Mode = (Mode)newValue;
        }

        private static void ImageDostavkaPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomButtonAddress)bindable;
            var controlVM = control.BindingContext as CustomButtonAddressViewModel;
            controlVM.ImagePathDostavka = (ImageSource)newValue;
        }
        private static void ImageRestoranPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomButtonAddress)bindable;
            var controlVM = control.BindingContext as CustomButtonAddressViewModel;
            controlVM.ImagePathRestoran = (ImageSource)newValue;
        }

        public CustomButtonAddress()
        {
            InitializeComponent();
        }
    }
}