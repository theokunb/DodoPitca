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
    public partial class CustomTovar : ContentView
    {
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath),typeof(ImageSource),typeof(CustomTovar),null,BindingMode.TwoWay,propertyChanged:ImagePathPropertyChanged);
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),typeof(string),typeof(CustomTovar),"",BindingMode.TwoWay, propertyChanged:TitlePropertyChanged);
        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(nameof(Description),typeof(string),typeof(CustomTovar),"",BindingMode.TwoWay,propertyChanged:DescriptionPropertyChanged);
        public static readonly BindableProperty PriceProperty = BindableProperty.Create(nameof(Price),typeof(string),typeof(CustomTovar),"",BindingMode.TwoWay,propertyChanged:PricePropertyChanged);

        

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

        public string Description
        {
            get { return GetValue(DescriptionProperty).ToString(); }
            set { SetValue(DescriptionProperty, value); }
        }

        public string Price
        {
            get { return GetValue(PriceProperty).ToString(); }
            set { SetValue(PriceProperty, value); }
        }

        private static void ImagePathPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTovar)bindable;
            var controlVM = control.BindingContext as CustomTovarViewModel;
            controlVM.ImagePath = (ImageSource)newValue;
        }
        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTovar)bindable;
            var controlVM = control.BindingContext as CustomTovarViewModel;
            controlVM.Title = newValue.ToString();
        }
        private static void DescriptionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTovar)bindable;
            var controlVM = control.BindingContext as CustomTovarViewModel;
            controlVM.Description = newValue.ToString();
        }
        private static void PricePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTovar)bindable;
            var controlVM = control.BindingContext as CustomTovarViewModel;
            controlVM.Price = newValue.ToString();
        }
        public CustomTovar()
        {
            InitializeComponent();
        }
    }
}