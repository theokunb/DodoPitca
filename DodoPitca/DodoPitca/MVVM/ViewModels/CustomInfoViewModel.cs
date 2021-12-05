using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomInfoViewModel : BaseViewModel
    {
        private Mode2 testo;
        private Mode3 size;
        private string[,] combination = new string[2, 3] { { "Малеькая 25 см, традиционное тесто, 330 г", "Средняя 30 см, традиционное тесто, 480 г", "Большая 35 см, традиционное тесто, 650 г" },
            { "Малеькая 25 см, тонкое тесто, 140 г", "Средняя 30 см, тонкое тесто, 370 г", "Большая 35 см, тонкое тесто, 540 г" } };
        
        public string Info
        {
            get
            {
                return combination[(int)Testo, (int)Size];
            }
        }
        public Mode3 Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    //problem
                    MessagingCenter.Send<BaseViewModel, Mode3>(this, Strings.SIZE_CHANGED, Size);
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(Info));
                }
            }
        }
        public Mode2 Testo
        {
            get => testo;
            set
            {
                if (testo != value)
                {
                    testo = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(Info));
                }
            }
        }

    }
}
