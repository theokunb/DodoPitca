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
        public ICommand CommandOpenTovarView { get; }

        public Pitca()
        {
            CommandOpenTovarView = new Command(param =>
              {
                  Application.Current.MainPage.Navigation.PushModalAsync(new PagePitcaView()
                  {
                      TitleTovar = Title,
                      Description = Description,
                      ImagePath = ImagePath,
                  });
              });
        }
    }
}
