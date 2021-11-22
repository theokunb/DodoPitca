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
        private Mode2 mode;
        private string textDostavka = DostavkaAddresses.addresses[0].Address;
        private string textRestoran = RestoranAddresses.addresses[0].Address;
        
        public string TextDostavka
        {
            get => textDostavka;
            set
            {
                if(textDostavka != value)
                {
                    textDostavka = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayText));
                }
            }
        }
        public string TextRestoran
        {
            get => textRestoran;
            set
            {
                if (textRestoran != value)
                {
                    textRestoran = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayText));
                }
            }
        }

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
        public Mode2 Mode
        {
            get => mode;
            set
            {
                if (mode != value)
                {
                    mode = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayImage));
                    OnpropertyChagned(nameof(DisplayText));
                }
            }
        }
        public ImageSource DisplayImage
        {
            get
            {
                switch (Mode)
                {
                    case Mode2.First: return ImagePathDostavka;
                    case Mode2.Second: return ImagePathRestoran;
                    default: return ImagePathDostavka;
                }
            }
        }
        public string DisplayText
        {
            get
            {
                switch (Mode)
                {
                    case Mode2.First: return TextDostavka;
                    case Mode2.Second: return TextRestoran;
                    default: return TextDostavka;
                }
            }
        }

        public ICommand CommandSelectAddress { get; }

        public CustomButtonAddressViewModel()
        {
            MessagingCenter.Subscribe<BaseViewModel, string>(this, Strings.SET_ADDRESS, (sender, param) =>
             {
                 if (Mode == Mode2.First)
                     TextDostavka = param;
                 else if (Mode == Mode2.Second)
                     TextRestoran = param;
             });
            MessagingCenter.Subscribe<BaseViewModel, string>(this, Strings.SELECT_DOSTAVKA_ADDRESS, (sender, param) => 
            {
                TextDostavka = param;
            });
            MessagingCenter.Subscribe<BaseViewModel, string>(this, Strings.SELECT_RESTORAN_ADDRESS, (sender, param) =>
            {
                TextRestoran = param;
            });
            CommandSelectAddress = new Command(param =>
            {
                if (Mode == Mode2.First)
                    Application.Current.MainPage.Navigation.PushModalAsync(new PageDostavkaAddress(TextDostavka));
                else if (Mode == Mode2.Second)
                    Application.Current.MainPage.Navigation.PushModalAsync(new PageResoranAddress(TextRestoran));
            });
        }
    }
}
