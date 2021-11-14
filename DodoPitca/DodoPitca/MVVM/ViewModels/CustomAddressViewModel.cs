using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomAddressViewModel:BaseViewModel
    {
        private string fullAddress;
        private string comment;

        public string FullAddress
        {
            get => fullAddress;
            set
            {
                if (fullAddress != value)
                {
                    fullAddress = value;
                    OnpropertyChagned();
                }
            }
        }
        public string Comment
        {
            get => comment;
            set
            {
                if (comment != value)
                {
                    comment = value;
                    OnpropertyChagned();
                }
            }
        }

    }
}
