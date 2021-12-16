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
    public partial class CustomProfileFrame : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(CustomProfileFrame), "", BindingMode.TwoWay, propertyChanged: TitlePropertyChanged);
        public static readonly BindableProperty CoinsProperty = BindableProperty.Create(nameof(Coins), typeof(int), typeof(CustomProfileFrame), 0, BindingMode.TwoWay, propertyChanged: CoinsPropertyChanged);
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath), typeof(ImageSource), typeof(CustomProfileFrame), null, BindingMode.TwoWay, propertyChanged: ImagePathPropertyChanged);
        
        public string Title
        {
            get { return GetValue(TitleProperty).ToString(); }
            set { SetValue(TitleProperty, value); }
        }
        public int Coins
        {
            get { return (int)GetValue(CoinsProperty); }
            set { SetValue(CoinsProperty, value); }
        }
        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomProfileFrame)bindable;
            var controlVM = control.BindingContext as CustomProfileFrameViewModel;
            controlVM.Title = newValue.ToString();
        }

        private static void CoinsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomProfileFrame)bindable;
            var controlVM = control.BindingContext as CustomProfileFrameViewModel;
            controlVM.Coins = Convert.ToInt32(newValue);
        }
        private static void ImagePathPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomProfileFrame)bindable;
            var controlVM = control.BindingContext as CustomProfileFrameViewModel;
            controlVM.ImagePath = (ImageSource)newValue;
        }
        public CustomProfileFrame()
        {
            InitializeComponent();
        }
    }
}