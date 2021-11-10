using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomButtonViewModel : BaseViewModel
    {
        private string cityTitle;
        private ImageSource imagePath;
        public string CityTitle
        {
            get => cityTitle;
            set
            {
                if (cityTitle == value)
                    return;
                cityTitle = value;
                OnpropertyChagned();
            }
        }
        public ImageSource ImagePath
        {
            get => imagePath;
            set
            {
                if (imagePath != value)
                {
                    imagePath = value;
                    OnpropertyChagned();
                }
            }
        }

        public ICommand CommandSelectCity { get; }

        
        public CustomButtonViewModel()
        {
            CommandSelectCity = new Command(async param =>
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new PageCitySelect(CityTitle));
            });
            MessagingCenter.Subscribe<BaseViewModel, string>(this, Strings.SET_CITY, (obj ,param) =>
            {
                CityTitle = param;
            });
        }
    }
}
