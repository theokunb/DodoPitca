using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class ProfileViewModel: BaseViewModel
    {
        private string userName;
        private int coins = 0;

        public int ActionsCount { get => Actions.Count; }
        public int DostavkaAddressesCount { get => DostavkaAddresses.addresses.Count; }
        public ObservableCollection<PersonalAction> Actions { get; set; }
        public string UserName
        {
            get => userName;
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnpropertyChagned();
                }
            }
        }

        public int Coins
        {
            get => coins;
            set
            {
                if (coins != value)
                {
                    coins = value;
                    OnpropertyChagned();
                }
            }
        }
        public ProfileViewModel()
        {
            UserName = "Алексей";
            Actions = new ObservableCollection<PersonalAction>();
            Actions.Add(new PersonalAction()
            {
                Title = "Пепперони 25 см в подарок при заказе от 999 р",
                ExpireDate = new DateTime(2021, 12, 30),
                Tovar = new Pitca()
                {
                    ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.peperoni380.png"),
                    Title = "Пепперони",
                    Description = "Пикантная пеперони, увеличенная ппорция моцареллы, томатный соус",
                    Price = 0,
                    BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Пепперони.png")
                },
                Description = "Пепперони 25 см в подарок при заказе от 990 р. Акция действует в течение 7 с момента получения промокода. Скидка по промокоду не сумируется. Промокод дейстует один раз. Акция не действет при заказе комбо."
            });
            MessagingCenter.Subscribe<BaseViewModel, int>(this, Strings.ADD_COINS, (sender, param) =>
            {
                Coins += param;
            });

        }
    }
}
