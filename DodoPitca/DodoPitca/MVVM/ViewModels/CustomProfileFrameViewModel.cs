using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomProfileFrameViewModel:BaseViewModel
    {
        private string title;
        private int coins;
        private ImageSource imagePath;
        public string Title
        {
            get => title;
            set
            {
                if (title == value)
                    return;
                title = value;
                OnpropertyChagned();
            }
        }
        public int Coins
        {
            get => coins;
            set
            {
                if (coins == value)
                    return;
                coins = value;OnpropertyChagned();
            }
        }
        public ImageSource ImagePath
        {
            get => imagePath;
            set
            {
                if (imagePath == value)
                    return;
                imagePath = value;
                OnpropertyChagned();
            }
        }
    }
}
