using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomContactsButtonViewModel : BaseViewModel
    {
        private string text;

        public string Text
        {
            get => text;
            set
            {
                if (text == value)
                    return;
                text = value; OnpropertyChagned();
            }
        }
    }
}
