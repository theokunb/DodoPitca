using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.Models
{
    public class PersonalAction:BaseViewModel
    {
        private DateTime expireDate;
        private string title;
        private Tovar tovar;
        private string description;

        public DateTime ExpireDate
        {
            get => expireDate;
            set
            {
                if (expireDate != value)
                {
                    expireDate = value;
                    OnpropertyChagned();
                }
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if(title != value)
                {
                    title = value;
                    OnpropertyChagned();
                }
            }
        }
        public Tovar Tovar
        {
            get => tovar;
            set
            {
                if (tovar != value)
                {
                    tovar = value;
                    OnpropertyChagned();
                }
            }
        }
        public string Description
        {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    OnpropertyChagned();
                }
            }
        }

        public PersonalAction()
        {

        }
    }
}
