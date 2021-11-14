using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.Models
{
    public static class RestoranAddresses
    {
        public static List<RestoranAddress> addresses = new List<RestoranAddress>()
        {
            new RestoranAddress("улица Дзержинского","11",new TimeSpan(8,30,0),new TimeSpan(23,0,0)),
            new RestoranAddress("улица Кирова","31",new TimeSpan(8,20,0),new TimeSpan(23,0,0)),
        };
    }

    public class RestoranAddress
    {
        private string street;
        private string house;
        private TimeSpan startWork;
        private TimeSpan endWork;

        public RestoranAddress(string street,string house, TimeSpan startWork, TimeSpan endWork)
        {
            this.street = street;
            this.house = house;
            this.startWork = startWork;
            this.endWork = endWork;
        }

        public string Address
        {
            get
            {
                return street + ", " + house;
            }
        }
        public string WorkTime
        {
            get
            {
                return "с " + startWork.ToString() + " до " + endWork.ToString();
            }
        }
    }
}
