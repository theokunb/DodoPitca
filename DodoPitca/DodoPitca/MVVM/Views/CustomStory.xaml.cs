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
    public partial class CustomStory : ContentView
    {
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath),typeof(ImageSource),typeof(CustomStory),null,BindingMode.TwoWay,propertyChanged: ImagePathPropertyChanged);

        private static void ImagePathPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomStory)bindable;
            var controlVM = control.BindingContext as CustomStoryViewModel;
            controlVM.ImagePath = (ImageSource)newValue;
        }

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }


        public CustomStory()
        {
            InitializeComponent();
        }
    }
}