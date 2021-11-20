using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class CustomTovarViewModel:BaseViewModel
    {
        protected ImageSource imagePath;
        protected string title;
        protected string description;
        protected string price;

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
        public string Description
        {
            get => description;
            set
            {
                if (description == value)
                    return;
                description = value;
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

        public ICommand CommandOpenTovarView { get; }

        public CustomTovarViewModel()
        {
            CommandOpenTovarView = new Command(param =>
              {
                  Application.Current.MainPage.Navigation.PushModalAsync(new PageTovarView()
                  {
                      TitleTovar = Title,
                      Description = Description,
                      ImagePath = ImagePath,
                      Info="info about this tovar =)"
                  });
              });
        }
    }
}
