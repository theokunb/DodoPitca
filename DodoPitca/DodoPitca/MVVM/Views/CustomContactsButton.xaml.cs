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
    public partial class CustomContactsButton : ContentView
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),typeof(string),typeof(CustomContactsButton),"",BindingMode.TwoWay,propertyChanged:TextPropertyChanged);


        public string Text
        {
            get {return GetValue(TextProperty).ToString(); }
            set { SetValue(TextProperty, value); }
        }

        private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomContactsButton)bindable;
            var controlVM = control.BindingContext as CustomContactsButtonViewModel;
            controlVM.Text = newValue.ToString();
        }

        public CustomContactsButton()
        {
            InitializeComponent();
        }
    }
}