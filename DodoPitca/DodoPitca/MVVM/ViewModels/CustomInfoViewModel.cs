using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomInfoViewModel : BaseViewModel
    {
        private Mode2 testo;


        public string Info
        {
            get
            {
                if (Testo == Mode2.First)
                    return "Традиционное тесто";
                else
                    return "Тонкое тесто";
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
