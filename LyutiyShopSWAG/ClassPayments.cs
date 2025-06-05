using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
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
}
