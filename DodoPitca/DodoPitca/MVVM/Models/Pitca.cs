using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class Pitca:Tovar
    {
        private string info;
        private Mode2 testo = Mode2.First;

        public string Info
        {
            get => info;
            set
            {
                if (info != value)
                {
                    info = value;
                    OnpropertyChagned();
                }
            }
        }
        public Mode2 Testo
        {
            get => testo;
            set
            {
                if (testo != value)
                {
                    testo = value;
                    OnpropertyChagned();
                    OnpropertyChagned(Info);
                }
            }
        }
        private string testoStr
        {
            get
            {
                if (testo == Mode2.First)
                    return "Традиционное";
                else
                    return "Тонкое";
            }
        }
        public ICommand CommandOpenTovarView { get; }

        public Pitca()
        {
            Info = testoStr + " ," + mass + "гр.";
            CommandOpenTovarView = new Command(param =>
              {
                  Application.Current.MainPage.Navigation.PushModalAsync(new PageTovarView()
                  {
                      TitleTovar = Title,
                      Description = Description,
                      ImagePath = ImagePath,
                      Info = Info
                  });
              });
        }
    }
}
