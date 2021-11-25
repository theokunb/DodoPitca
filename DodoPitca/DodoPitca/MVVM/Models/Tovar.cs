﻿using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.Models
{
    public abstract class Tovar : BaseViewModel
    {
        protected ImageSource imagePath;
        protected string title;
        protected string description;
        protected string price;
        protected int mass;
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
    }
}
