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

    internal class oplataKartoy : IOplata 
    {
        public void Oplatit()
        {
            int new_balance = Vallet.Instance.Card.balance - ShoppingCart.Instance.SummaPokupok;
            if (new_balance > 0)
            {
                ShoppingCart.Instance.SummaPokupok = 0;
                Vallet.Instance.Card.balance = new_balance;
                ShoppingCart.Instance.ClearCart();
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
                ShoppingCart.Instance.ClearCart();
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
                ShoppingCart.Instance.ClearCart();
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
