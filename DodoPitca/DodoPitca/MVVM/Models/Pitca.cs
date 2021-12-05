using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class Pitca : Tovar
    {
        private Mode3 size;
        public Mode3 Size
        {
            get=> size;
            set
            {
                if (size != value)
                {
                    size = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(FinalPrice));
                }
            }
        }
        public string FinalPrice
        {
            get
            {
                int additional = 0; // dopi
                int basePrice = 0; // price po razmeru
                switch (Size)
                {
                    case Mode3.First:
                        {
                            basePrice = Price;
                            break;
                        }
                    case Mode3.Second:
                        {
                            basePrice = Price + 150;
                            break;
                        }
                    case Mode3.Third:
                        {
                            basePrice = Price + 350;
                            break;
                        }
                }
                foreach(var element in Ingridienti)
                {
                    if (element.IsChecked)
                        additional += element.Price;
                }
                return $"В корзину за {basePrice + additional} р";
            }
        }
        public ObservableCollection<Ingidient> Ingridienti { get; set; }
        public Pitca()
        {
            MessagingCenter.Subscribe<BaseViewModel>(this, Strings.UPDATE_INGRIDIENTS, (sender) =>
            {
                OnpropertyChagned(nameof(FinalPrice));
            });
            Ingridienti = new ObservableCollection<Ingidient>();
            CommandBuy = new Command(param =>
            {
                MessagingCenter.Send<BaseViewModel, object>(this, Strings.ADD_KORZINA, this);
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
    }
}
