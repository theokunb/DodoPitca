using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageCitySelectViewModel : BaseViewModel
    {


        public ICommand CommandExit { get; }
        public ICommand CommandSetCity { get; }
        public PageCitySelectViewModel()
        {
            CommandExit = new Command(async o =>
            {
                await App.Current.MainPage.Navigation.PopModalAsync();
            });
            CommandSetCity = new Command(param =>
            {
                MessagingCenter.Send<BaseViewModel,string>(this, Strings.SET_CITY, "Москва");
            });
        }
    }
}
