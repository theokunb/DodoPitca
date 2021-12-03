using DodoPitca.MVVM.Models;
using DodoPitca.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DodoPitca.MVVM.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly ObservableCollection<Tovar> tovars = new ObservableCollection<Tovar>();
        private readonly ObservableCollection<Tovar> newAndHot = new ObservableCollection<Tovar>();

        public ObservableCollection<Tovar> Tovars { get => tovars; }
        public ObservableCollection<Tovar> NewAndHot { get => newAndHot; }
        public ICommand CommandSearchTovar { get; }
        public ICommand CommandViewTovar { get; }
        public ICommand CommandViewNewAndHot { get; }
        public MenuViewModel()
        {
            LoadTovars();
            LoadNewAndHot();
            CommandSearchTovar = new Command(param =>
            {
                Application.Current.MainPage.Navigation.PushModalAsync(new PageSearchTovar());
                MessagingCenter.Send<BaseViewModel, ObservableCollection<Tovar>>(this, Strings.FIND_TOVARS, Tovars);
            });
            CommandViewTovar = new Command(param =>
            {
                if (int.TryParse(param.ToString(), out int id))
                {
                    var selectedItem = Tovars.First(item => item.Id == id);
                    if (selectedItem.GetType() == typeof(Pitca))
                    {
                        Application.Current.MainPage.Navigation.PushModalAsync(new PagePitcaView(selectedItem as Pitca, Tovars.Where(item => item.GetType() == typeof(Pitca))));
                    }
                }
            });
            CommandViewNewAndHot = new Command(param =>
            {
                if (int.TryParse(param.ToString(), out int id))
                {
                    var selectedItem = Tovars.First(item => item.Id == id);
                    if (selectedItem.GetType() == typeof(Pitca))
                    {
                        Application.Current.MainPage.Navigation.PushModalAsync(new PagePitcaView(selectedItem as Pitca));
                    }
                }
            });
        }
        private void LoadNewAndHot()
        {
            string[] collection = new string[] { "Сырная", "Пепперони фреш", "Песто", "Аррива!", "Додо" };
            foreach(var item in Tovars.Where(item => collection.Contains(item.Title)))
            {
                NewAndHot.Add(item);
            }
        }
        private int Randomizer()
        {
            Random rand = new Random();
            int res;
            while (true)
            {
                res = rand.Next();
                if (Tovars.Where(item => item.Id == res).Count() == 0)
                    return res;
            }
        }
        private void LoadTovars()
        {
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.diablo.png"),
                Title = "Диабло",
                Description = "Острая чоризо, острый перец халапеньо, соуус барбекю, митболы, томаты, сладкий перец, красный лук, моцарелла, томатный соус",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Диабло.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.sirniTciplenok.png"),
                Title = "Сырный цыпленок",
                Description = "Цыпленок, моцарелла, сыры чеддер и пармезан, сырный соус, томаты, соус альфредо, чеснок",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Сырный цыпленок.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pitcaTychki.png"),
                Title = "Пицца от Тучки с игрушкой из коллекции",
                Description = "Ветчина, картошка, моцарелла, соус альфредо",
                Price = "от 529 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Пицца от Тучки с игрушкой из коллекции.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pitcaKeshi.png"),
                Title = "Пицца от Кеши с игрушкой из коллекции",
                Description = "Цыпленок, картошка, томаты, моцарелла, томатный соус",
                Price = "от 529 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Пицца от Кеши с игрушкой из коллекции.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.kolbaskiBarbeku.png"),
                Title = "Колбаски Барбекю",
                Description = "Острая чоризо, соус барбекю, томаты, красный лук, моцарелла, томатный соус",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Колбаски Барбекю.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.margarita.png"),
                Title = "Маргарита",
                Description = "Увеличенная порция моцареллы, томаты, итальянские травы, томатный соус",
                Price = "от 435 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Маргарита.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.arriva.png"),
                Title = "Аррива!",
                Description = "Цыпленок, острая чоризо, соус бурргер, сладкий перец, красный лук, томаты, моцарелла, соус ранч, чеснок",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Аррива.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.peperoni380.png"),
                Title = "Пепперони",
                Description = "Пикантная пеперони, увеличенная ппорция моцареллы, томатный соус",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Пепперони.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.vetchinaGribi.png"),
                Title = "Ветчина и грибы",
                Description = "Ветчина, шампиньоны, увеличенная порция моцареллы, томатный соус",
                Price = "от 435 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Ветчина и грибы.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.sirnaya2.png"),
                Title = "Сырная",
                Description = "Моцарелла, сыры чеддер и пармезан, соус альфредо",
                Price = "от 295 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Сырная.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.vetchinaSir.png"),
                Title = "Ветчина и сыр",
                Description = "Ветчина, моцарелла, соус альфредо",
                Price = "от 375 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Ветчина и сыр.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.doubleTsiplenok.png"),
                Title = "Двойной цыпленок",
                Description = "Цыпленок, моцарелла, соус альфредо",
                Price = "от 375 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Двойной цыпленок.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.dodoMiks.png"),
                Title = "Додо микс",
                Description = "Бекон, цыпленок, ветчина, сыр блю чиз, сыры чеддер и пармезан, соус песто, кубики брынзы, томаты, красный лук, моцарелла, соус альфредо, чеснок, итальянские травы",
                Price = "от 625 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Додо Микс.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.peperoniFresh.png"),
                Title = "Пепперони фреш",
                Description = "Пикантная пепперони, увеличенная порция моцареллы, томаты, томатный соус",
                Price = "от 295 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Пепперони фреш.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pesto.png"),
                Title = "Песто",
                Description = "Цыпленок, соус песто, кубики брынзы, томаты, моцарелла, соус альфредо",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Песто.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.karbonara.png"),
                Title = "Карбонара",
                Description = "Бекон, сыры чеддер и пармезан, моцарелла, томаты, красный лук, чеснок, соус альфредо, итальянские травы",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Карбонара.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.fristailo.png"),
                Title = "Фристайло",
                Description = "Томаты, сладкий перец, красный лук, соус песто, митболы, моцарелла, томатный соус",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Фристайло.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.chizborger.png"),
                Title = "Чизбургер-пицца",
                Description = "Мясной соус болоньезе, соус бургер, соленые огурчики, томаты, красный лук, моцарелла",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Чизбургер-пицца.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.gavaiskaya.png"),
                Title = "Гавайская",
                Description = "Ветчина, ананасы, моцарелла, томатный соус",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Гавайская.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.fourSeason.png"),
                Title = "Четыре сезона",
                Description = "Увеличенная порчия моцареллы, ветчина, пикантная пепперони, кубики брынзы, томаты, шампиньоны, итальянские травы, томатный соус",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Четыре сезона.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.ovoshiGribi.png"),
                Title = "Овощи и грибы",
                Description = "Шампиньоны, томаты, сладкий перец, красный лук, маслины, кубики брынзы, моцарелла, томатный соус, итальянские травы",
                Price = "от 495 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Овощи и грибы.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.dodo.png"),
                Title = "Додо",
                Description = "Бекон, митболы, пикантная пепперони, моцарелла, томаты, шампиньоны, сладкий перец, красный лук, чеснок, томатный соус",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Додо.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.fourSir.png"),
                Title = "Четыре сыра",
                Description = "Сыр блю чиз, сыры чеддер и пармезан, моцарелла, соус альфредо",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Четыре сыра.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.myasnaya.png"),
                Title = "Мясная",
                Description = "Цыпленок, ветчина, пикантная пепперони, острая чоризо, моцарелла, томатный соус",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Мясная.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.tciplenokRanch.png"),
                Title = "Цыпленок ранч",
                Description = "Цыпленок, ветчина, соус ранч, моцарелла, томаты, чеснок",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Цыпленок ранч.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.tciplenokBarbeky.png"),
                Title = "Цыпленок барбекю",
                Description = "Цыпленок, бекон, соус барбекю, красный лук, моцарелла, томатный соус",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Цыпленок барбекю.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.doublePeperoni.png"),
                Title = "Двойная пепперони",
                Description = "Двойная порция пикантной пепперони, увеличенная порция моцареллы, томатный сооус",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Двойная пепперони.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.superMyasnaya.png"),
                Title = "Супермясная",
                Description = "Пикантная пеперрони, цыпленок, острая чоризо, бекон, митболы, моцарелла, томатный соус",
                Price = "от 625 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Супермясная.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.pitcaPirog.png"),
                Title = "Пицца-пирог",
                Description = "Ананасы, брусника, сгущенное молоко",
                Price = "от 435 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Пицца-пирог.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.nejniLosos.png"),
                Title = "Нежный лосось",
                Description = "Лосось, томаты, соус песто, моцарелла, соус альфредо",
                Price = "от 675 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Нежный лосось.png")
            });
            Tovars.Add(new Pitca()
            {
                ImagePath = ImageSource.FromResource("DodoPitca.Images.Pitci.meksikanskaya.png"),
                Title = "Мексиканская",
                Description = "Цыпленок, остный перец халапеньо, соус сальса, томаты, сладкий перец, красный лук, моцарелла, томатный соус",
                Price = "от 545 р",
                Id = Randomizer(),
                BigImage = ImageSource.FromResource("DodoPitca.Images.BigPitci.Мексиканская.png")
            });
        }
    }
}