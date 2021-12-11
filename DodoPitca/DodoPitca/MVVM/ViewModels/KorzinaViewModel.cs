using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class KorzinaViewModel: BaseViewModel
    {
        public ObservableCollection<Tovar> Tovars { get; set; }
        public KorzinaViewModel()
        {
            Tovars = new ObservableCollection<Tovar>();
            MessagingCenter.Subscribe<BaseViewModel, object>(this, Strings.ADD_KORZINA, (sender, param) =>
            {
                if (param.GetType() == typeof(Pitca))
                    Tovars.Add(param as Pitca);
                else if (param.GetType() == typeof(Zakuska))
                    Tovars.Add(param as Zakuska);
            });
        }
    }
}
