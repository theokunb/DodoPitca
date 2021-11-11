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
    public partial class CustomToggleBotton : ContentView
    {
        public CustomToggleBotton()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizerON_Tapped(object sender, EventArgs e)
        {
            Slider.TranslateTo(0, 0);
        }

        private void TapGestureRecognizerOFF_Tapped(object sender, EventArgs e)
        {
            Slider.TranslateTo(baseRect.Width / 2, 0);
        }
    }
}