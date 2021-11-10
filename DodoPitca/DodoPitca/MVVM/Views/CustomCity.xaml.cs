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
    public partial class CustomCity : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),typeof(string),typeof(CustomCity),"",BindingMode.TwoWay,propertyChanged:TitlePropertyChanged);
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath),typeof(ImageSource),typeof(CustomCity),null,BindingMode.TwoWay,propertyChanged:ImagePathPropertyChanged);
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked),typeof(bool),typeof(CustomCity),false,BindingMode.TwoWay,propertyChanged:IsChechedPropertyChanged);


        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }
        public string Title
        {
            get { return GetValue(TitleProperty).ToString(); }
            set { SetValue(TitleProperty, value); }
        }
        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CustomCity;
            var controlVM = control.BindingContext as CustomCityViewModel;
            controlVM.Title = newValue.ToString();
        }
        private static void ImagePathPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CustomCity;
            var controlVM = control.BindingContext as CustomCityViewModel;
            controlVM.ImagePath = newValue as ImageSource;
        }
        private static void IsChechedPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CustomCity;
            var controlVM = control.BindingContext as CustomCityViewModel;
            controlVM.IsChecked = (bool)newValue;
        }
        public CustomCity()
        {
            InitializeComponent();
        }
    }
}