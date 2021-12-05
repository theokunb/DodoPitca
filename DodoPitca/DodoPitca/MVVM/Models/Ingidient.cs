using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.Models
{
    public static class IngridientDone
    {
        public static Ingidient SirniBortic { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.siriniBortik.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Сырный бортик",
            Price = 179,
            IsChecked = false
        };
        public static Ingidient Mocarella { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.mocarella.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Моцарелла",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Halapenio { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.holopenio.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Острый халапеньо",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Tciplenok { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.tciplenok.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Цыпленок",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Gribi { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.gribi.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Шампиньоны",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Vetchina { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.bekon.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Бекон",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient BluChees { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.bluchees.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Блю чиз",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Kolbaski { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.kolbaski.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Пикантная пепперони",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Maslini { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.maslini.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Маслины",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Perec { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.perec.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Сладкий перец",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient RedOnion { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.redOnion.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Красный лук",
            Price = 79,
            IsChecked = false
        };
        public static Ingidient Tomati { get; } = new Ingidient()
        {
            ImageIngedient = ImageSource.FromResource("DodoPitca.Images.Ingidienti.tomati.png"),
            ImageCheck = ImageSource.FromResource("DodoPitca.Images.checkOrange.png"),
            Text = "Томаты",
            Price = 79,
            IsChecked = false
        };
    }
    public class Ingidient : BaseViewModel
    {
        private ImageSource imageIngedient;
        private ImageSource imageCheck;
        private string text;
        private int price;
        private bool isChecked;


        public bool IsChecked
        {
            get => isChecked;
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    MessagingCenter.Send<BaseViewModel>(this, Strings.UPDATE_INGRIDIENTS);
                    OnpropertyChagned();
                }
            }
        }
        public string DisplayPrice
        {
            get => Price + "p";
        }
        public int Price
        {
            get => price;
            set
            {
                if (price != value)
                {
                    price = value;
                    OnpropertyChagned();
                    OnpropertyChagned(nameof(DisplayPrice));
                }
            }
        }
        public string Text
        {
            get => text;
            set
            {
                if (text != value)
                {
                    text = value;
                    OnpropertyChagned();
                }
            }
        }
        public ImageSource ImageCheck
        {
            get => imageCheck;
            set
            {
                if (imageCheck != value)
                {
                    imageCheck = value;
                    OnpropertyChagned();
                }
            }
        }
        public ImageSource ImageIngedient
        {
            get => imageIngedient;
            set
            {
                if (imageIngedient != value)
                {
                    imageIngedient = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandTap { get; }

        public Ingidient()
        {
            CommandTap = new Command(param =>
            {
                IsChecked = !IsChecked;
            });
        }
        /// <summary>
        /// Создает клон объекта
        /// </summary>
        /// <returns></returns>
        public Ingidient Clone()
        {
            Ingidient res = new Ingidient();
            res.ImageIngedient = ImageIngedient;
            res.ImageCheck = ImageCheck;
            res.Text = Text;
            res.Price = Price;
            res.IsChecked = IsChecked;
            return res;
        }
    }
}
