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
    public partial class CustomInfo : ContentView
    {
        public static readonly BindableProperty TestoProperty = BindableProperty.Create(nameof(Testo), typeof(Mode2), typeof(CustomInfo), Mode2.First, BindingMode.TwoWay, propertyChanged: TestoPropertyChanged);
        public static readonly BindableProperty SizeProperty = BindableProperty.Create(nameof(Size), typeof(Mode3), typeof(CustomInfo), Mode3.Second, BindingMode.TwoWay, propertyChanged: SizePropertyChnaged);

        

        public Mode3 Size
        {
            get { return (Mode3)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }
        public Mode2 Testo
        {
            get { return (Mode2)GetValue(TestoProperty); }
            set { SetValue(TestoProperty, value); }
        }
        private static void SizePropertyChnaged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomInfoViewModel;
            controlVM.Size = (Mode3)newValue;
        }
        private static void TestoPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var controlVM = bindable.BindingContext as CustomInfoViewModel;
            controlVM.Testo = (Mode2)newValue;
        }


        public CustomInfo()
        {
            InitializeComponent();
        }
    }
}