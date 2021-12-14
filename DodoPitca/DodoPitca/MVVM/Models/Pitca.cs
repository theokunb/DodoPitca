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
        private Mode2 testo;
        private string[,] combination = new string[2, 3] { { "Малеькая 25 см, традиционное тесто, 330 г", "Средняя 30 см, традиционное тесто, 480 г", "Большая 35 см, традиционное тесто, 650 г" },
            { "Малеькая 25 см, тонкое тесто, 140 г", "Средняя 30 см, тонкое тесто, 370 г", "Большая 35 см, тонкое тесто, 540 г" } };

        public Mode2 Testo
        {
            get => testo;
            set
            {
                if (testo != value)
                {
                    testo = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(Sum));
                    OnpropertyChagned(nameof(FinalPrice));
                    OnpropertyChagned(nameof(Info));
                }
            }
        }
        public Mode3 Size
        {
            get=> size;
            set
            {
                if (size != value)
                {
                    size = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(Sum));
                    OnpropertyChagned(nameof(FinalPrice));
                    OnpropertyChagned(nameof(Info));
                }
            }
        }
        public override int Sum
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
                foreach (var element in Ingridienti)
                {
                    if (element.IsChecked)
                        additional += element.Price;
                }
                return basePrice + additional;
            }
        }
        public string FinalPrice
        {
            get
            {
                return $"В корзину за {Sum} р";
            }
        }
        public override string Info
        {
            get
            {
                string s = combination[(int)Testo, (int)Size];
                foreach(var element in Ingridienti)
                {
                    if (element.IsChecked)
                        s += ", " + element.Text;
                }
                return s;
            }
        }

        public ObservableCollection<Ingidient> Ingridienti { get; set; }
        

        public Pitca()
        {
            MessagingCenter.Subscribe<BaseViewModel>(this, Strings.UPDATE_INGRIDIENTS, (sender) =>
            {
                OnpropertyChagned(nameof(Sum));
                OnpropertyChagned(nameof(FinalPrice));
                OnpropertyChagned(nameof(Info));
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
