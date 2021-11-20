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
    public partial class PageTovarView : ContentPage
    {
        public static readonly BindableProperty TitleTovarProperty = BindableProperty.Create(nameof(TitleTovar),typeof(string),typeof(PageTovarView),string.Empty,BindingMode.TwoWay,propertyChanged:TitlePropertyChanged);
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath),typeof(ImageSource),typeof(PageTovarView),null,BindingMode.TwoWay,propertyChanged:ImagePathPropertyChanged);
        public static readonly BindableProperty InfoProperty = BindableProperty.Create(nameof(Info), typeof(string), typeof(PageTovarView), string.Empty, BindingMode.TwoWay, propertyChanged: InfoPropertyChanged);
        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(nameof(Description), typeof(string), typeof(PageTovarView), string.Empty, BindingMode.TwoWay, propertyChanged:DescriptionPropertyChanged);

        private static void DescriptionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as PageTovarViewModel;
            controlVM.Description = newValue.ToString();
        }

        private static void InfoPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as PageTovarViewModel;
            controlVM.Info= newValue.ToString();
        }

        private static void ImagePathPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as PageTovarViewModel;
            controlVM.ImagePath = (ImageSource)newValue;
        }

        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as PageTovarViewModel;
            controlVM.Title = newValue.ToString();
        }

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }
        public string TitleTovar
        {
            get { return GetValue(TitleTovarProperty).ToString(); }
            set { SetValue(TitleTovarProperty, value); }
        }
        public string Info
        {
            get { return GetValue(InfoProperty).ToString(); }
            set { SetValue(InfoProperty, value); }
        }
        public string Description
        {
            get { return GetValue(DescriptionProperty).ToString(); }
            set { SetValue(DescriptionProperty, value); }
        }

        public PageTovarView()
        {
            InitializeComponent();
        }
    }
}