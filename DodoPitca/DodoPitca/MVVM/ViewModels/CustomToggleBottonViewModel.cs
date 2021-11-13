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
        private Mode mode;

        public ICommand CommandSwitchMode { get; }
        public Mode Mode
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
        public CustomToggleBottonViewModel()
        {
            CommandSwitchMode = new Command(param =>
              {
                  Enum.TryParse(param.ToString(), out Mode tmp);
                  Mode = tmp;

              });
        }
    }
}
