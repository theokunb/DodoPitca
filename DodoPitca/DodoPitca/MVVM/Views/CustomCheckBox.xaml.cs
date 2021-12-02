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
    public partial class CustomCheckBox : ContentView
    {
        public static readonly BindableProperty ImageIngedientProperty = BindableProperty.Create(nameof(ImageIngedient),typeof(ImageSource),typeof(CustomCheckBox),null,BindingMode.TwoWay,propertyChanged: ImageIngedientPropertyChanged);
        public static readonly BindableProperty ImageCheckProperty = BindableProperty.Create(nameof(ImageCheck),typeof(ImageSource),typeof(CustomCheckBox),null,BindingMode.TwoWay,propertyChanged: ImageCheckPropertyChanged);
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),typeof(string),typeof(CustomCheckBox),string.Empty,BindingMode.TwoWay,propertyChanged:TextPropertyChanged);
        public static readonly BindableProperty PriceProperty = BindableProperty.Create(nameof(Price),typeof(string),typeof(CustomCheckBox),string.Empty,BindingMode.TwoWay,propertyChanged:PricePropertyChanged);
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked),typeof(bool),typeof(CustomCheckBox),false,BindingMode.TwoWay,propertyChanged: IsCheckedPropertyChanged);

        private static void IsCheckedPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomCheckBoxViewModel;
            controlVM.IsChecked = (bool)newValue;
        }

        private static void PricePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomCheckBoxViewModel;
            controlVM.Price = (string)newValue;
        }

        private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomCheckBoxViewModel;
            controlVM.Text = (string)newValue;
        }

        private static void ImageCheckPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomCheckBoxViewModel;
            controlVM.ImageCheck = (ImageSource)newValue;
        }

        private static void ImageIngedientPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomCheckBoxViewModel;
            controlVM.ImageIngedient = (ImageSource)newValue;
        }

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }
        public string Price
        {
            get { return GetValue(PriceProperty).ToString(); }
            set { SetValue(PriceProperty, value); }
        }
        public string Text
        {
            get { return GetValue(TextProperty).ToString(); }
            set { SetValue(TextProperty, value); }
        }
        public ImageSource ImageCheck
        {
            get { return (ImageSource)GetValue(ImageCheckProperty); }
            set { SetValue(ImageCheckProperty, value); }
        }
        public ImageSource ImageIngedient
        {
            get { return (ImageSource)GetValue(ImageIngedientProperty); }
            set { SetValue(ImageIngedientProperty, value); }
        }


        public CustomCheckBox()
        {
            InitializeComponent();
        }
    }
}