using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomAddressViewModel : BaseViewModel
    {
        private string fullAddress;
        private string comment;
        private bool isSelected;


        public bool IsSelected
        {
            get => isSelected;
            set
            {
                if(isSelected!=value)
                {
                    isSelected = value;
                    OnpropertyChagned();
                }
            }
        }
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
