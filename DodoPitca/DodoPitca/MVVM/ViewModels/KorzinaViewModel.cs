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
        private int sum;



        public int Sum
        {
            get => sum;
            set 
            {
                if (sum != value)
                {
                    sum = value;
                    OnpropertyChagned();
                }
            }
        }
        public ObservableCollection<Tovar> Tovars { get; set; }
        public KorzinaViewModel()
        {
            Tovars = new ObservableCollection<Tovar>();
            MessagingCenter.Subscribe<BaseViewModel, object>(this, Strings.ADD_KORZINA, (sender, param) =>
            {
                if (param.GetType() == typeof(Pitca))
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Tovars.Add(param as Pitca);
                        Sum += (param as Pitca).TotalPrice;
                    });

                else if (param.GetType() == typeof(Zakuska))
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Tovars.Add(param as Zakuska);
                        Sum+=(param as Zakuska).Price;
                    });
            });
        }
    }
}
