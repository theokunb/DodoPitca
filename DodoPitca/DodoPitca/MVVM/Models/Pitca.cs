using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class Pitca : Tovar
    {
        public ObservableCollection<Ingidient> Ingridienti { get; set; }
        public Pitca()
        {
            Ingridienti = new ObservableCollection<Ingidient>();
        }
    }
}
