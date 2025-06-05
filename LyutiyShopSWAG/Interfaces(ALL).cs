using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    public interface IOplataView
    {
        event EventHandler PayByCardClicked;
        event EventHandler PayByCashClicked;
        event EventHandler PayByBonusClicked;
        event EventHandler CancelClicked;

        
    }
    public interface IShelvesView
    {
        event EventHandler AddTomatoClicked;
        event EventHandler RemoveTomatoClicked;

        event EventHandler AddCucumberClicked;
        event EventHandler RemoveCucumberClicked;

        event EventHandler AddPotatoClicked;
        event EventHandler RemovePotatoClicked;

        event EventHandler AddCarrotClicked;
        event EventHandler RemoveCarrotClicked;

        event EventHandler AddOnionClicked;
        event EventHandler RemoveOnionClicked;

        event EventHandler AddCabbageClicked;
        event EventHandler RemoveCabbageClicked;

        event EventHandler AddTomatoesPackedClicked;
        event EventHandler RemoveTomatoesPackedClicked;

        event EventHandler AddPotatoesPackedClicked;
        event EventHandler RemovePotatoesPackedClicked;

        event EventHandler AddCarrotsPackedClicked;
        event EventHandler RemoveCarrotsPackedClicked;

        event EventHandler LeaveToKassaClicked;
        event EventHandler WeighClicked;

    }

}
