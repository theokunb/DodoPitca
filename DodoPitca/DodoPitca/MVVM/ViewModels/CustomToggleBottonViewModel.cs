using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomToggleBottonViewModel:BaseViewModel
    {
        private Mode2 mode;
        private string firstText;
        private string secondText;

        public ICommand CommandSwitchMode { get; }
        public Mode2 Mode
        {
            get => mode;
            set
            {
                if(mode!=value)
                {
                    mode = value;
                    OnpropertyChagned();
                }
            }
        }
        public string FirstText
        {
            get => firstText;
            set
            {
                if (firstText != value)
                {
                    firstText = value;
                    OnpropertyChagned();
                }
            }
        }


        public string SecondText
        {
            get => secondText;
            set
            {
                if (secondText != value)
                {
                    secondText = value;
                    OnpropertyChagned();
                }
            }
        }
        public CustomToggleBottonViewModel()
        {
            CommandSwitchMode = new Command(param =>
              {
                  Enum.TryParse(param.ToString(), out Mode2 tmp);
                  Mode = tmp;
              });
        }
    }
}
