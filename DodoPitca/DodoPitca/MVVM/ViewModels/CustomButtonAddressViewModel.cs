using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomButtonAddressViewModel : BaseViewModel
    {
        private ImageSource imagePathDostavka;
        private ImageSource imagePathRestoran;
        private Mode mode;
        public ImageSource ImagePathDostavka
        {
            get => imagePathDostavka;
            set
            {
                if (imagePathDostavka != value)
                {
                    imagePathDostavka = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayImage));
                }
            }
        }
        public ImageSource ImagePathRestoran
        {
            get => imagePathRestoran;
            set
            {
                if (imagePathRestoran != value)
                {
                    imagePathRestoran = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayImage));
                }
            }
        }
        public Mode Mode
        {
            get => mode;
            set
            {
                if (mode != value)
                {
                    mode = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayImage));
                }
            }
        }
        public ImageSource DisplayImage
        {
            get
            {
                switch (Mode)
                {
                    case Mode.Dostavka: return ImagePathDostavka;
                    case Mode.Restoran: return ImagePathRestoran;
                    default: return ImagePathDostavka;
                }
            }
        }

        public ICommand CommandSelectAddress { get; }

        public CustomButtonAddressViewModel()
        {
            CommandSelectAddress = new Command(param =>
            {
                if (Mode == Mode.Dostavka)
                    Application.Current.MainPage.Navigation.PushModalAsync(new PageDostavkaAddress());
                else if (Mode == Mode.Restoran)
                    Application.Current.MainPage.Navigation.PushModalAsync(new PageResoranAddress());

            });
        }
    }
}
