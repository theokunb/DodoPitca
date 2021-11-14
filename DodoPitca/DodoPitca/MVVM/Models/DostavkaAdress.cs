using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.Models
{
    public static class DostavkaAddresses
    {
        public static List<DostavkaAddress> addresses = new List<DostavkaAddress>()
        {
            new DostavkaAddress("Чернышевского","4","Работа","попросить охрану позонить 1122, что бы пропустили. второй этаж по лестнице, повортор налево, каб 201"),
            new DostavkaAddress("Чернышевского","4")
        };
        public static void AddAddress(DostavkaAddress address)
        {
            addresses.Add(address);
        }
    }

    public class DostavkaAddress : Address
    {
        private readonly string kvartira;
        private readonly string podezd;
        private readonly int floor;
        private readonly string titleAddress = "Дом";
        private readonly string comment;
        public DostavkaAddress(string street, string house, string kvartira, string podezd, int floor, string titleAddress, string comment)
        {
            this.street = street;
            this.house = house;
            this.kvartira = kvartira;
            this.podezd = podezd;
            this.floor = floor;
            this.titleAddress = titleAddress;
            this.comment = comment;
        }
        public DostavkaAddress(string street, string house, string titleAddress, string comment)
        {
            this.street = street;
            this.house = house;
            this.titleAddress = titleAddress;
            this.comment = comment;
        }
        public DostavkaAddress(string street, string house, string titleAddress)
        {
            this.street = street;
            this.house = house;
            this.titleAddress = titleAddress;
        }
        public DostavkaAddress(string street, string house)
        {
            this.street = street;
            this.house = house;
        }
        public string Address
        {
            get
            {
                string comma = ", ";
                string res = street + comma + house;
                if (!(kvartira is null) && kvartira != string.Empty)
                {
                    res += comma; res += kvartira;
                }
                if (!(podezd is null) && podezd != string.Empty)
                {
                    res += comma;
                    res += podezd;
                }
                return res;
            }
        }
        public string Comment
        {
            get => comment;
        }
        public string Title
        {
            get => titleAddress;
        }

    }
}
