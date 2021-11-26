using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomToggle3ViewModel:BaseViewModel
    {
        private Mode3 mode;
        private string firstText;
        private string secondText;
        private string thirdText;

        public Mode3 Mode
        {
            get => mode;
            set
            {
                if (mode != value)
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
                if(firstText!=value)
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
        public string ThirdText
        {
            get => thirdText;
            set
            {
                if (thirdText != value)
                {
                    thirdText = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandSwitchMode { get; }

        public CustomToggle3ViewModel()
        {
            CommandSwitchMode = new Command(param =>
            {
                Enum.TryParse(param.ToString(), out Mode3 res);
                Mode = res;
            });
        }
    }
}
