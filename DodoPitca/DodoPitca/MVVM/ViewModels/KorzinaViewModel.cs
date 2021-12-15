using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
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
                    OnpropertyChagned(nameof(ButtonTextPay));
                    OnpropertyChagned(nameof(AllSum));
                    OnpropertyChagned(nameof(BonusCoins));
                }
            }
        }
        public string AllSum
        {
            get
            {
                return $"{Tovars.Count} товара на {Tovars.Sum(element => element.Sum)}";
            }
        }
        public string ButtonTextPay
        {
            get => $"ОФОРМИТЬ ЗА {Sum}";
        }
        public string BonusCoins
        {
            get => $"Начислим додокоинов    +{(int)(Tovars.Sum(element => element.Sum) * 0.05)} D";
        }
        public ObservableCollection<Tovar> Tovars { get; set; }
        public ICommand CommandPay { get; }
        public KorzinaViewModel()
        {
            Tovars = new ObservableCollection<Tovar>();
            MessagingCenter.Subscribe<BaseViewModel, object>(this, Strings.ADD_KORZINA, (sender, param) =>
            {
                if (param.GetType() == typeof(Pitca))
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Tovars.Add(param as Pitca);
                        Sum += (param as Pitca).Sum;
                    });

                else if (param.GetType() == typeof(Zakuska))
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Tovars.Add(param as Zakuska);
                        Sum+=(param as Zakuska).Price;
                    });
            });
            CommandPay = new Command(param =>
            {
                MessagingCenter.Send<BaseViewModel, int>(this, Strings.ADD_COINS, (int)(Tovars.Sum(element => element.Sum) * 0.05));
                Tovars.Clear();
                Sum = 0;
            });
        }
    }
}
