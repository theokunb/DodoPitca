using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.ViewModels;
using System;
using System.Collections.Generic;
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
        private View[] tovars;
        public PageSearchTovar(IList<View> views)
        {
            InitializeComponent();
            tovars = new View[views.Count];
            views.CopyTo(tovars, 0);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

            if ((sender as Entry).Text == string.Empty)
            {
                stackTovars.Children.Clear();
                return;
            }
            Regex reg = new Regex("^" + (BindingContext as PageSearchTovarViewModel).SearchPattern + @".*$", RegexOptions.IgnoreCase);
            for(int i = 0; i < tovars.Length; i++)
            {
                for(int j = stackTovars.Children.Count - 1; j >= 0; j--)
                {
                    if (stackTovars.Children.Contains(stackTovars.Children[j]) && !reg.IsMatch((stackTovars.Children[j] as CustomTovar).Title))
                        stackTovars.Children.Remove(stackTovars.Children[j]);
                }
                if(reg.IsMatch((tovars[i] as CustomTovar).Title))
                {
                    bool povtorenie = false;
                    for(int k = 0; k < stackTovars.Children.Count; k++)
                    {
                        if ((stackTovars.Children[k] as CustomTovar).Title == (tovars[i] as CustomTovar).Title)
                            povtorenie = true;
                        if (povtorenie)
                            break;
                    }
                    if (povtorenie)
                        continue;
                    stackTovars.Children.Add(new CustomTovar()
                    {
                        Title = (tovars[i] as CustomTovar).Title,
                        Description = (tovars[i] as CustomTovar).Description,
                        Price = (tovars[i] as CustomTovar).Price,
                        ImagePath = (tovars[i] as CustomTovar).ImagePath
                    });
                }
            }
        }
    }
}