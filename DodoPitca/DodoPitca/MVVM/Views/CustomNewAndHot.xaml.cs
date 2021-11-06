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
    public partial class CustomNewAndHot : ContentView
    {
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath),typeof(ImageSource),typeof(CustomNewAndHot),null,BindingMode.TwoWay,propertyChanged:ImagePathPropertyChagned);
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),typeof(string),typeof(CustomNewAndHot),"",BindingMode.TwoWay,propertyChanged:TitlePropetyChanged);
        public static readonly BindableProperty PriceProperty = BindableProperty.Create(nameof(Price),typeof(string),typeof(CustomNewAndHot),"",BindingMode.TwoWay,propertyChanged:PricePropertyChanged);

        private static void ImagePathPropertyChagned(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomNewAndHot)bindable;
            var controlVM = control.BindingContext as CustomNewAndHotViewModel;
            controlVM.ImagePath = (ImageSource)newValue;
        }
        private static void TitlePropetyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomNewAndHot)bindable;
            var controlVM = control.BindingContext as CustomNewAndHotViewModel;
            controlVM.Title = newValue.ToString();
        }
        private static void PricePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomNewAndHot)bindable;
            var controlVM = control.BindingContext as CustomNewAndHotViewModel;
            controlVM.Price = newValue.ToString();
        }
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

        public string Price
        {
            get { return GetValue(PriceProperty).ToString(); }
            set { SetValue(PriceProperty, value); }
        }

        public CustomNewAndHot()
        {
            InitializeComponent();
        }
    }
}