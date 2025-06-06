using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    internal class Vallet : IElement
    {
        private static readonly Lazy<Vallet> _instance = new Lazy<Vallet>(() => new Vallet());
        public static Vallet Instance => _instance.Value;

        public debetovaya_karta Card;
        public bonusnaya_karta BonusCard;
        public int Nalichka { get; set; }

        private IOplata _strategy;

        private Vallet()
        {
            Random rnd = new Random();
            Nalichka = rnd.Next(0, 50);
            Card = new debetovaya_karta();
            BonusCard = new bonusnaya_karta();
        }

        // Установка стратегии
        public void SetStrategy(IOplata strategy)
        {
            _strategy = strategy;
        }

        // Выполнение оплаты через установленную стратегию
        public void SdelatOplatu()
        {
            ///!!!!!!!!!!!
            ShoppingCart.Instance.ForcedCartCost(); 
            ///!!!!!!!!!!

            if (ShoppingCart.Instance.SummaPokupok == 0)
            {
                MessageBox.Show("Ваша корзина пуста.");
                return;
            }

            if (_strategy == null)
            {
                MessageBox.Show("Чем платить-то?");
                return;
            }

            _strategy.Oplatit();
        }

        // Для посетителя
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
