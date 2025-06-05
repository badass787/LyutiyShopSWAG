using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
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
    ///////////
    
    ///VISITORS

    //////////
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

            
            vallet.Card.Accept(this);
            vallet.BonusCard.Accept(this);
        }
    }

}
