using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    public class OplataPresenter
    {
        private readonly ShoppingCart cart = ShoppingCart.Instance;
        private readonly IOplataView view;


        public OplataPresenter(IOplataView view)
        {
            this.view = view;
            this.cart = ShoppingCart.Instance;

            this.view.PayByCardClicked += OnPayByCard;
            this.view.PayByCashClicked += OnPayByCash;
            
            this.view.balClicked += OnBalance;

        }

        private void OnPayByCard(object? sender, EventArgs e)
        {
            if (Vallet.Instance.BonusCard.flag) { oplataBonusami oplataBonusami = new oplataBonusami(); Vallet.Instance.SetStrategy(oplataBonusami);
                Vallet.Instance.SdelatOplatu();
            }
            else { Vallet.Instance.BonusCard.addCredit(ShoppingCart.Instance.SummaPokupok); }
            oplataKartoy oplata = new oplataKartoy();
            Vallet.Instance.SetStrategy(oplata);
            Vallet.Instance.SdelatOplatu();
            CheckIfBOMJ();
        }

        private void OnPayByCash(object? sender, EventArgs e)
        {
            if (Vallet.Instance.BonusCard.flag)
            {
                oplataBonusami oplataBonusami = new oplataBonusami(); Vallet.Instance.SetStrategy(oplataBonusami);
                Vallet.Instance.SdelatOplatu();
            }
            else { Vallet.Instance.BonusCard.addCredit(ShoppingCart.Instance.SummaPokupok); }
            oplataNalom oplata = new oplataNalom();
            Vallet.Instance.SetStrategy(oplata);
            Vallet.Instance.SdelatOplatu();
            CheckIfBOMJ();
        }

        private void OnPayByBonus(object? sender, EventArgs e)
        {
            oplataBonusami oplata = new oplataBonusami();
            Vallet.Instance.SetStrategy(oplata);
            Vallet.Instance.SdelatOplatu();
            CheckIfBOMJ();
        }

        private void OnBalance(object? sender, EventArgs e)
        {
            BalanceDisplayVisitor visitor = new BalanceDisplayVisitor();

            Vallet myVallet = Vallet.Instance;

            myVallet.Accept(visitor);

        }





        private void CheckIfBOMJ()
        {
            int totalBalance =
                Vallet.Instance.Card.balance +
                Vallet.Instance.Nalichka +
                Vallet.Instance.BonusCard.balance;

            if (totalBalance < ShoppingCart.Instance.SummaPokupok)
            {
                view.TriggerBOMJ(); 
            }
        }

    }
}
