using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PageTovarViewModel : CustomTovarViewModel
    {
        private string info;

        public string Info
        {
            get => info;
            set
            {
                if(info!=value)
                {
                    info = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandBack { get; }
        public PageTovarViewModel()
        {
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
    }
}
