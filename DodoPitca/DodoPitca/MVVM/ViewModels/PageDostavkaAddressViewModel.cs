using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageDostavkaAddressViewModel : BaseViewModel
    {
        public ICommand CommandBack { get; }

        public PageDostavkaAddressViewModel()
        {
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
    }
}
