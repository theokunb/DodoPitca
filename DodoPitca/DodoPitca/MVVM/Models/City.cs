using System;
using System.Collections.Generic;
using System.Text;

namespace DodoPitca.MVVM.Models
{
    public enum City
    {
        Yakutsk,
        Moscow,
        Krasnodar
    }
    public static class CityHelp
    {
        public static string GetTitle(City city)
        {
            if (city == City.Yakutsk)
                return "Якутск";
            else if (city == City.Moscow)
                return "Москва";
            else if (city == City.Krasnodar)
                return "Краснодар";
            return "";
        }
    }
    
}
