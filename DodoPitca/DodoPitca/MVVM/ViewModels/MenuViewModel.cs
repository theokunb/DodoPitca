using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public ICommand commandSelectCity { get; }


        public MenuViewModel()
        {
            commandSelectCity = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PushAsync(new PageCitySelect());
            });
        }
    }
}
