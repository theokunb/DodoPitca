using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DodoPitca.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSearchTovar : ContentPage
    {
        public PageSearchTovar()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var allCollection = (BindingContext as PageSearchTovarViewModel).Tovars;
            ObservableCollection<Tovar> displayCollection = (BindingContext as PageSearchTovarViewModel).DisplayTovars;

            if ((sender as Entry).Text == string.Empty)
            {
                displayCollection.Clear();
                return;
            }
            Regex reg = new Regex("^" + (BindingContext as PageSearchTovarViewModel).SearchPattern + @".*$", RegexOptions.IgnoreCase);
            for(int i = 0; i < allCollection.Count; i++)
            {
                for(int j = displayCollection.Count - 1; j >= 0; j--)
                {
                    //если элемент есть в коллекции и не подходит регулярному выражению
                    if (displayCollection.Contains(displayCollection[j]) && !reg.IsMatch(displayCollection[j].Title))
                        displayCollection.Remove(displayCollection[j]);
                }
                if(reg.IsMatch(allCollection[i].Title))
                {
                    bool povtorenie = false;
                    //проверка на повторение в отображаемой коллекции
                    for(int k = 0; k < displayCollection.Count; k++)
                    {
                        if (displayCollection[k].Title == allCollection[i].Title)
                            povtorenie = true;
                        if (povtorenie)
                            break;
                    }
                    if (povtorenie)
                        continue;
                    displayCollection.Add(new Pitca()
                    {
                        Title = allCollection[i].Title,
                        Description = allCollection[i].Description,
                        Price = allCollection[i].Price,
                        ImagePath = allCollection[i].ImagePath
                    });
                }
            }
        }
    }
}