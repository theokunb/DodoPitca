using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private ObservableCollection<Tovar> tovars = new ObservableCollection<Tovar>();
        private ObservableCollection<Tovar> newAndHot = new ObservableCollection<Tovar>();

        public ObservableCollection<Tovar> Tovars { get => tovars; }
        public ObservableCollection<Tovar> NewAndHot { get => newAndHot; }
        public ICommand CommandSearchTovar { get; }

        public MenuViewModel()
        {
            LoadNewAndHot();
            LoadTovars();
            CommandSearchTovar = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PushModalAsync(new PageSearchTovar());
                MessagingCenter.Send<BaseViewModel, ObservableCollection<Tovar>>(this, Strings.FIND_TOVARS, Tovars);
            });
        }
        private void LoadNewAndHot()
        {
            NewAndHot.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.peperoniFresh.png"),
                Title = "Пеперони фреш",
                Description = "Пикантная пепперони, увеличенная порция моцареллы, томаты, томатный соус",
                Price = "от 295 р"
            });
            NewAndHot.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.sirnaya2.png"),
                Title = "Сырная",
                Description = "Моцарелла, сыры чеддер и пармезан, соус альфредо",
                Price = "от 295 р"
            });
        }
        private void LoadTovars()
        {
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.diablo.png"),
                Title = "Диабло",
                Description = "Острая чоризо, острый перец халапеньо, соуус барбекю, митболы, томаты, сладкий перец, красный лук, моцарелла, томатный соус",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.sirniTciplenok.png"),
                Title = "Сырный цыпленок",
                Description = "Цыпленок, моцарелла, сыры чеддер и пармезан, сырный соус, томаты, соус альфредо, чеснок",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pitcaTychki.png"),
                Title = "Пицца от Тучки с игрушкой из коллекции",
                Description = "Ветчина, картошка, моцарелла, соус альфредо",
                Price = "от 529 р",
                Info = ""
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pitcaKeshi.png"),
                Title = "Пицца от Кеши с игрушкой из коллекции",
                Description = "Цыпленок, картошка, томаты, моцарелла, томатный соус",
                Price = "от 529 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.kolbaskiBarbeku.png"),
                Title = "Колбаски Барбекю",
                Description = "Острая чоризо, соус барбекю, томаты, красный лук, моцарелла, томатный соус",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.margarita.png"),
                Title = "Маргарита",
                Description = "Увеличенная порция моцареллы, томаты, итальянские травы, томатный соус",
                Price = "от 435 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.arriva.png"),
                Title = "Аррива!",
                Description = "Цыпленок, острая чоризо, соус бурргер, сладкий перец, красный лук, томаты, моцарелла, соус ранч, чеснок",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.peperoni380.png"),
                Title = "Пеперони",
                Description = "Пикантная пеперони, увеличенная ппорция моцареллы, томатный соус",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.vetchinaGribi.png"),
                Title = "Ветчина и грибы",
                Description = "Ветчина, шампиньоны, увеличенная порция моцареллы, томатный соус",
                Price = "от 435 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.diablo.png"),
                Title = "Диабло",
                Description = "Острая чоризо, острый перец халапеньо, соуус барбекю, митболы, томаты, сладкий перец, красный лук, моцарелла, томатный соус",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.sirnaya2.png"),
                Title = "Сырная",
                Description = "Моцарелла, сыры чеддер и пармезан, соус альфредо",
                Price = "от 295 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.vetchinaSir.png"),
                Title = "Ветчина и сыр",
                Description = "Ветчина, моцарелла, соус альфредо",
                Price = "от 375 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.doubleTsiplenok.png"),
                Title = "Двойной цыпленок",
                Description = "Цыпленок, моцарелла, соус альфредо",
                Price = "от 375 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pitcaIzPolovinok.png"),
                Title = "Пицца из половинок",
                Description = "Соберите свою пицу 35см с двумя разными вкусами",
                Price = "Собрать"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.dodoMiks.png"),
                Title = "Додо микс",
                Description = "Бекон, цыпленок, ветчина, сыр блю чиз, сыры чеддер и пармезан, соус песто, кубики брынзы, томаты, красный лук, моцарелла, соус альфредо, чеснок, итальянские травы",
                Price = "от 625 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.peperoniFresh.png"),
                Title = "Пеперони фреш",
                Description = "Пикантная пепперони, увеличенная порция моцареллы, томаты, томатный соус",
                Price = "от 295 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pesto.png"),
                Title = "Песто",
                Description = "Цыпленок, соус песто, кубики брынзы, томаты, моцарелла, соус альфредо",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.karbonara.png"),
                Title = "Карбонара",
                Description = "Бекон, сыры чеддер и пармезан, моцарелла, томаты, красный лук, чеснок, соус альфредо, итальянские травы",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.fristailo.png"),
                Title = "Фристайло",
                Description = "Томаты, сладкий перец, красный лук, соус песто, митболы, моцарелла, томатный соус",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.chizborger.png"),
                Title = "Чизбургер-пицца",
                Description = "Мясной соус болоньезе, соус бургер, соленые огурчики, томаты, красный лук, моцарелла",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.gavaiskaya.png"),
                Title = "Гавайская",
                Description = "Ветчина, ананасы, моцарелла, томатный соус",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.fourSeason.png"),
                Title = "Четыре сезона",
                Description = "Увеличенная порчия моцареллы, ветчина, пикантная пепперони, кубики брынзы, томаты, шампиньоны, итальянские травы, томатный соус",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.ovoshiGribi.png"),
                Title = "Овощи и грибы",
                Description = "Шампиньоны, томаты, сладкий перец, красный лук, маслины, кубики брынзы, моцарелла, томатный соус, итальянские травы",
                Price = "от 495 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.dodo.png"),
                Title = "Додо",
                Description = "Бекон, митболы, пикантная пепперони, моцарелла, томаты, шампиньоны, сладкий перец, красный лук, чеснок, томатный соус",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.fourSir.png"),
                Title = "Четыре сыра",
                Description = "Сыр блю чиз, сыры чеддер и пармезан, моцарелла, соус альфредо",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.myasnaya.png"),
                Title = "Мясная",
                Description = "Цыпленок, ветчина, пикантная пепперони, острая чоризо, моцарелла, томатный соус",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.tciplenokRanch.png"),
                Title = "Цыпленок ранч",
                Description = "Цыпленок, ветчина, соус ранч, моцарелла, томаты, чеснок",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.diablo.png"),
                Title = "Диабло",
                Description = "Острая чоризо, острый перец халапеньо, соуус барбекю, митболы, томаты, сладкий перец, красный лук, моцарелла, томатный соус",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.tciplenokBarbeky.png"),
                Title = "Цыпленок барбекю",
                Description = "Цыпленок, бекон, соус барбекю, красный лук, моцарелла, томатный соус",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.doublePeperoni.png"),
                Title = "Двойная пепперони",
                Description = "Двойная порция пикантной пепперони, увеличенная порция моцареллы, томатный сооус",
                Price = "от 545 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.superMyasnaya.png"),
                Title = "Супермясная",
                Description = "Пикантная пеперрони, цыпленок, острая чоризо, бекон, митболы, моцарелла, томатный соус",
                Price = "от 625 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pitcaPirog.png"),
                Title = "Пицца-пирог",
                Description = "Ананасы, брусника, сгущенное молоко",
                Price = "от 435 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.nejniLosos.png"),
                Title = "Нежный лосось",
                Description = "Лосось, томаты, соус песто, моцарелла, соус альфредо",
                Price = "от 675 р"
            });
            tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.meksikanskaya.png"),
                Title = "Мексиканская",
                Description = "Цыпленок, остный перец халапеньо, соус сальса, томаты, сладкий перец, красный лук, моцарелла, томатный соус",
                Price = "от 545 р"
            });



        }
    }
}