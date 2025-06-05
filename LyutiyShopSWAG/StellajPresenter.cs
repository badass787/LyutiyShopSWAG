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
        private readonly Stellaj storage = Stellaj.current;
        public StellajPresenter(IShelvesView view)
        {
            this.view = view;

            view.AddTomatoClicked += (_, __) => Add("Tomato", 1);
            view.RemoveTomatoClicked += (_, __) => Remove("Tomato", 1);

            view.AddCucumberClicked += (_, __) => Add("Cucumber", 1);
            view.RemoveCucumberClicked += (_, __) => Remove("Cucumber", 1);

            view.AddPotatoClicked += (_, __) => Add("Potato", 1);
            view.RemovePotatoClicked += (_, __) => Remove("Potato", 1);

            view.AddCarrotClicked += (_, __) => Add("Carrot", 1);
            view.RemoveCarrotClicked += (_, __) => Remove("Carrot", 1);

            view.AddOnionClicked += (_, __) => Add("Onion", 1);
            view.RemoveOnionClicked += (_, __) => Remove("Onion", 1);

            view.AddCabbageClicked += (_, __) => Add("Cabbage", 1);
            view.RemoveCabbageClicked += (_, __) => Remove("Cabbage", 1);

            view.AddTomatoesPackedClicked += (_, __) => Add("Tomato Packed", 1);
            view.RemoveTomatoesPackedClicked += (_, __) => Remove("Tomato Packed", 1);

            view.AddPotatoesPackedClicked += (_, __) => Add("Potato Packed", 1);
            view.RemovePotatoesPackedClicked += (_, __) => Remove("Potato Packed", 1);

            view.AddCarrotsPackedClicked += (_, __) => Add("Carrot Packed", 1);
            view.RemoveCarrotsPackedClicked += (_, __) => Remove("Carrot Packed", 1);

            view.LeaveToKassaClicked += OnGoToKassa;
            view.WeighClicked += OnWeigh;
        }

    }
}
