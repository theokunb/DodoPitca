using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomStoryViewModel:BaseViewModel
    {
        private ImageSource imagePath = null;
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
