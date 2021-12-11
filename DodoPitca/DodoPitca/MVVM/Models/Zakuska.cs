using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.Models
{
    public class Zakuska : Tovar
    {
        public string FinalPrice { get => $"В корзину за {Price} р"; }
        public Zakuska()
        {
            CommandBuy = new Command(param =>
            {
                MessagingCenter.Send<BaseViewModel, object>(this, Strings.ADD_KORZINA, this);
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
    }
}
