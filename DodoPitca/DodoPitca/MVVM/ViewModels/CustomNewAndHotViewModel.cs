using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomNewAndHotViewModel:BaseViewModel
    {
        private ImageSource imagePath;
        private string title;
        private string price;
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
        public string Price
        {
            get => price;
            set
            {
                if (price == value)
                    return;
                price = value;
                OnpropertyChagned();
            }
        }
    }
}
