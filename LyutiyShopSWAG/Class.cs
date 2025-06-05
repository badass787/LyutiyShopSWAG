using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    public interface IOplata
    {
        public void Oplatit();
    }

    internal interface IVisitor
    {
        void Visit(bonusnaya_karta karta);
        void Visit(debetovaya_karta karta);
        void Visit(Vallet vallet);
    }
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
    internal class BalanceDisplayVisitor : IVisitor
    {
        public void Visit(bonusnaya_karta karta)
        {
            MessageBox.Show($"Баланс бонусной карты ({karta.Number}): {karta.balance} бонусов");
        }

        public void Visit(debetovaya_karta karta)
        {
            MessageBox.Show($"Баланс дебетовой карты ({karta.Number}): {karta.balance} руб.");
        }

        public void Visit(Vallet vallet)
        {
            MessageBox.Show($"Наличные в кошельке: {vallet.Nalichka} руб.");

            // Также обходим вложенные карты
            vallet.Card.Accept(this);
            vallet.BonusCard.Accept(this);
        }
    }

    internal class ShoppingCart //это будет синглетон
    {
        private static readonly Lazy<ShoppingCart> _instance =
            new Lazy<ShoppingCart>(() => new ShoppingCart());

        public static ShoppingCart Instance => _instance.Value;

        public int SummaPokupok = 0;

        private ShoppingCart()
        {
            Random rnd = new Random();
            SummaPokupok = rnd.Next(10, 6000);
        }

        public void ThrowAway()
        {
            Random rnd = new Random();
            if (SummaPokupok > 10)
            {
                SummaPokupok = SummaPokupok - rnd.Next(10, SummaPokupok);
            }
            else { SummaPokupok = 0; }
        }
    }


    abstract class Karta
    {

        public string Number { get; set; }
        public int balance { get; set; } = 0;
    }

    internal class bonusnaya_karta : Karta, IElement
    {
        public bonusnaya_karta()
        {
            Number = "1234 6523 1239 4734";

            Random rnd = new Random();
            balance = rnd.Next(0, 99);
        }

        public bool flag = false;

        public void addCredit(int SummaOplati)
        {
            balance = balance + (int)MathF.Round(SummaOplati * 0.1f);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    internal class debetovaya_karta : Karta, IElement
    {
        private int CVC { get; set; }
        public debetovaya_karta()
        {
            Number = "2631 2137 9043 2178";
            Random rnd = new Random();
            balance = rnd.Next(0, 7000);
            CVC = rnd.Next(100, 1000);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

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
            Nalichka = rnd.Next(0, 5000);
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


    internal class oplataKartoy : IOplata //попытка в фабрик
    {
        public void Oplatit()
        {
            int new_balance = Vallet.Instance.Card.balance - ShoppingCart.Instance.SummaPokupok;
            if (new_balance > 0)
            {
                ShoppingCart.Instance.SummaPokupok = 0;
                Vallet.Instance.Card.balance = new_balance;
                MessageBox.Show("Вы оплатили картой");
            }
            else
            {
                ShoppingCart.Instance.SummaPokupok = Math.Abs(new_balance);
                Vallet.Instance.Card.balance = 0;
            }
        }
    }

    internal class oplataNalom : IOplata
    {
        public void Oplatit()
        {
            int new_balance = Vallet.Instance.Nalichka - ShoppingCart.Instance.SummaPokupok;
            if (new_balance > 0)
            {
                ShoppingCart.Instance.SummaPokupok = 0;
                Vallet.Instance.Nalichka = new_balance;
                MessageBox.Show("Вы оплатили наличкой");
            }
            else
            {
                ShoppingCart.Instance.SummaPokupok = Math.Abs(new_balance);
                Vallet.Instance.Nalichka = 0;
            }

        }
    }

    internal class oplataBonusami : IOplata
    {
        public void Oplatit()
        {
            int new_balance = ShoppingCart.Instance.SummaPokupok - Vallet.Instance.BonusCard.balance;
            if (new_balance > 0)
            {
                ShoppingCart.Instance.SummaPokupok = new_balance;
                Vallet.Instance.BonusCard.balance = 0;
            }
            else
            {
                Vallet.Instance.BonusCard.balance = Math.Abs(new_balance);
                ShoppingCart.Instance.SummaPokupok = 0;
                MessageBox.Show("Вам удалось оплатить бонусами");
            }
        }
    }
    internal class oplataDouble : IOplata
    {
        public void Oplatit()
        {
            int new_balance = Vallet.Instance.Card.balance + Vallet.Instance.Nalichka - ShoppingCart.Instance.SummaPokupok;
            if (new_balance > 0)
            {
                ShoppingCart.Instance.SummaPokupok = 0;
                Vallet.Instance.Card.balance = 0;
                Vallet.Instance.Nalichka = new_balance;
                MessageBox.Show("Вы оплатили картой и доплатили наличкой");
            }
            else
            {

                MessageBox.Show("Всех ваших денег не хватает чтобы оплатить покупки.");
            }
        }
    }
}
