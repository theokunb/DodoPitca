using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomCheckBoxViewModel : BaseViewModel
    {
        private ImageSource imageIngedient;
        private ImageSource imageCheck;
        private string text;
        private string price;
        private bool isChecked;


        public bool IsChecked
        {
            get => isChecked;
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    OnpropertyChagned();
                }
            }
        }
        public string DisplayPrice
        {
            get => Price + "p";
        }
        public string Price
        {
            get => price;
            set
            {
                if(price != value)
                {
                    price = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayPrice));
                }
            }
        }
        public string Text
        {
            get => text;
            set
            {
                if (text != value)
                {
                    text = value;
                    OnpropertyChagned();
                }
            }
        }
        public ImageSource ImageCheck
        {
            get => imageCheck;
            set
            {
                if (imageCheck != value)
                {
                    imageCheck = value;
                    OnpropertyChagned();
                }
            }
        }
        public ImageSource ImageIngedient
        {
            get => imageIngedient;
            set
            {
                if(imageIngedient!=value)
                {
                    imageIngedient = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandTap { get; }

        public CustomCheckBoxViewModel()
        {
            CommandTap = new Command(param =>
            {
                IsChecked = !IsChecked;
            });
        }
    }
}
