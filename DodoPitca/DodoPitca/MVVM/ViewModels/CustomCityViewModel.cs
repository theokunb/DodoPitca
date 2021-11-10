using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomCityViewModel:BaseViewModel
    {
        private string title;
        private ImageSource imagePath;
        private bool isChecked = false;
        public string Title
        {
            get => title; 
            set
            {
                if(title!=value)
                {
                    title = value;
                    OnpropertyChagned();
                }
            }
        }
        public ImageSource ImagePath
        {
            get => imagePath;
            set
            {
                if(imagePath!=value)
                {
                    imagePath = value;
                    OnpropertyChagned();
                }
            }
        }
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
    }
}