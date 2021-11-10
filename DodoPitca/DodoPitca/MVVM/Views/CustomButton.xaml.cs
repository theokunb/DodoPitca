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
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath), typeof(ImageSource), typeof(CustomButton), null, BindingMode.TwoWay, propertyChanged: ImagePathPropertyChanged);

        

        public string CityTitle
        {
            get { return GetValue(CityTitleProperty).ToString(); }
            set { SetValue(CityTitleProperty, value); }
        }
        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }


        private static void CityTitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
                return;
            var control = (CustomButton)bindable;
            var controlVM = control.BindingContext as CustomButtonViewModel;
            controlVM.CityTitle = newValue.ToString();
        }
        private static void ImagePathPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
                return;
            var control = (CustomButton)bindable;
            var controlVM = control.BindingContext as CustomButtonViewModel;
            controlVM.ImagePath = (ImageSource)newValue;
        }
        public CustomButton()
        {
            InitializeComponent();
        }
    }
}