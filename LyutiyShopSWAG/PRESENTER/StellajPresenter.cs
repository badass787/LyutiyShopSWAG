using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    internal class StellajPresenter
    {
        private readonly IShelvesView view;
        private readonly ShoppingCart cart = ShoppingCart.Instance;
        //private readonly Stellaj storage = Stellaj.current;
        public StellajPresenter(IShelvesView view)
        {
            this.view = view;

            view.AddTomatoClicked += (_, __) => ShoppingCart.Instance.AddProduct(1);
            view.RemoveTomatoClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(1);

            view.AddCucumberClicked += (_, __) => ShoppingCart.Instance.AddProduct(2);
            view.RemoveCucumberClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(2);

            view.AddPotatoClicked += (_, __) => ShoppingCart.Instance.AddProduct(3);
            view.RemovePotatoClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(3);

            view.AddCarrotClicked += (_, __) => ShoppingCart.Instance.AddProduct(4);
            view.RemoveCarrotClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(4);

            view.AddOnionClicked += (_, __) => ShoppingCart.Instance.AddProduct(5);
            view.RemoveOnionClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(5);

            view.AddCabbageClicked += (_, __) => ShoppingCart.Instance.AddProduct(6);
            view.RemoveCabbageClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(6);

            view.AddTomatoesPackedClicked += (_, __) => ShoppingCart.Instance.AddProduct(7);
            view.RemoveTomatoesPackedClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(7);

            view.AddPotatoesPackedClicked += (_, __) => ShoppingCart.Instance.AddProduct(8);
            view.RemovePotatoesPackedClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(8);

            view.AddCarrotsPackedClicked += (_, __) => ShoppingCart.Instance.AddProduct(9);
            view.RemoveCarrotsPackedClicked += (_, __) => ShoppingCart.Instance.RemoveProduct(9);

            
            view.WeighClicked += (_, __) => ShoppingCart.Instance.WeighMeasurableProducts();
            view.countSummaClicked += (_, __) => ShoppingCart.Instance.GetCartCost();
        }

    }
}
