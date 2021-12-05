using DodoPitca.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class PagePitcaViewModel : BaseViewModel
    {
        private int selectedId;
        
        public ObservableCollection<Pitca> Pitci { get; set; }
        public int SelectedId
        {
            get => selectedId;
            set
            {
                if (selectedId != value)
                {
                    selectedId = value;
                    OnpropertyChagned();
                }
            }
        }
        public ICommand CommandBack { get; }

        public PagePitcaViewModel()
        {
            Pitci = new ObservableCollection<Pitca>();
            CommandBack = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });

            MessagingCenter.Subscribe<BaseViewModel, Mode3>(this, Strings.SIZE_CHANGED, (sender, param) =>
            {
                Pitci[SelectedId].Size = param;
            });
        }
    }
}
