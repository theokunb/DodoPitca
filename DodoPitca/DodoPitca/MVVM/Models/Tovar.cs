using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.Models
{
    public abstract class Tovar : BaseViewModel
    {
        protected int id;
        protected ImageSource imagePath;
        protected string title;
        protected string description;
        protected int price;
        protected int mass;
        protected ImageSource bigImage;

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
        public ImageSource BigImage
        {
            get => bigImage;
            set
            {
                if (bigImage != value)
                {
                    bigImage = value;
                    OnpropertyChagned();
                }
            }
        }
        public int Id
        {
            get => id;
            set
            {
                if (id != value)
                {
                    id = value;
                    OnpropertyChagned();
                }
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
        public string DisplayPrice
        {
            get => $"от {Price} p";
        }
        public int Price
        {
            get => price;
            set
            {
                if (price == value)
                    return;
                price = value;
                OnpropertyChagned();
                OnpropertyChagned(nameof(DisplayPrice));
            }
        }
        public int Mass
        {
            get => mass;
            set
            {
                if (mass != value)
                {
                    mass = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandBuy { get; protected set; }
    }
}
