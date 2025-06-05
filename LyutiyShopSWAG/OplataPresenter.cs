using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    public   class OplataPresenter
    {
        private readonly ShoppingCart cart = ShoppingCart.Instance;
        private readonly IOplataView view;

        public OplataPresenter(IOplataView view)
        {
            this.view = view;
            this.cart = ShoppingCart.Instance;

            this.view.PayByCardClicked += OnPayByCard;
            this.view.PayByCashClicked += OnPayByCash;
            this.view.PayByBonusClicked += OnPayByBonus;
            this.view.CancelClicked += OnCancel;
        }

        private void OnPayByCard(object? sender, EventArgs e)
        {
           
        }

        private void OnPayByCash(object? sender, EventArgs e)
        {
            
        }

        private void OnPayByBonus(object? sender, EventArgs e)
        {
            
        }

        private void OnCancel(object? sender, EventArgs e)
        {
            
        }
    
}
}
