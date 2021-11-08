using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomButtonViewModel : BaseViewModel
    {
        private City currentCity = City.Yakutsk;

        public City CurrentCity
        {
            get => currentCity;
            set
            {
                if (currentCity == value)
                    return;
                currentCity = value;
                OnpropertyChagned();
            }
        }
        public string DisplayCity
        {
            get => CityHelp.GetTitle(CurrentCity);
        }
        public CustomButtonViewModel()
        {
            
        }
    }
}
