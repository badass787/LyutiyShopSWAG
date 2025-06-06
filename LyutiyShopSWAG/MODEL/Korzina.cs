using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    internal class ShoppingCart : IElement
    {
        private static readonly Lazy<ShoppingCart> _instance =
            new Lazy<ShoppingCart>(() => new ShoppingCart());

        public static ShoppingCart Instance => _instance.Value;

        public void Accept(IVisitor visitor) { }

        public event Action CartChanged;

        public int SummaPokupok = 0;

        private Dictionary<IpaketikAndGoods, int> cartItems = new(); //используем затычку
        //private Random rnd = new Random();

        private ShoppingCart() { }

        public int GetCountByID(int id)
        {
            var kvp = cartItems.FirstOrDefault(x => x.Key.ID == id);
            return kvp.Key != null ? kvp.Value : 0;
        }

        public void AddProduct(int ID)
        {

            Goods item = Stellaj.allGoods.Find(g => g.ID == ID);
            if (Stellaj.Instance.getAmount(item.Name) > 0)
            {
                var existingKey = cartItems.Keys.FirstOrDefault(k => k.ID == item.ID);
                if (existingKey == null)
                {

                    if (item is MeasurableGoods md)
                    {
                        var newPaketik = new Paketik(ID, md);
                        cartItems[newPaketik] = newPaketik.PaketOvoshey.Count;
                    }
                    else
                    {
                        cartItems.Add(item, 1);
                    }
                }
                else { cartItems[existingKey] += 1; }

                Stellaj.Instance.ChangeAmount(item.ID, -1);

                MessageBox.Show($"Добавлено:{item.Description}");
                CartChanged?.Invoke();
            }
            else { }
        }


        public void RemoveProduct(int ID)
        {
            Goods item = Stellaj.allGoods.Find(g => g.ID == ID);

            var existingKey = cartItems.Keys.FirstOrDefault(k => k.ID == item.ID);
            if (existingKey == null)
            {
                MessageBox.Show("Товар не найден в корзине.");
                return;
            }

            int currentCount = cartItems[existingKey];

            if (currentCount > 0)
            {
                cartItems[existingKey] -= 1;

                Stellaj.Instance.ChangeAmount(item.ID, 1); // возвращаем товар на полку
                UpdateCartCost();
                MessageBox.Show($"Удалено: {item.Description}");
                CartChanged?.Invoke();
            }
            else
            {
                MessageBox.Show("Нельзя уменьшить количество ниже 0.");
            }
        }



        public void WeighMeasurableProducts()
        {
            float totalWeight = 0;
        
            foreach (var kvp in cartItems)
            {
                if (kvp.Key is Paketik paket && paket.PaketOvoshey.Count() >0)
                {
                    MessageBox.Show($"Вы кладете на весы {paket.PaketOvoshey[0].Name}...");
                    float weight = paket.weighAll();
                    MessageBox.Show($"Вес: {weight}");

                }
            }
        
            MessageBox.Show($"Вы взвесили всё, что можно было взвесить.");
            
        }

        public int GetCartCost()
        {
            int cost = 0;
            foreach (var kvp in cartItems)
            { 
            if (kvp.Key is Paketik paket)
                {
                    if (paket.totalCost <= 0)
                    {
                        MessageBox.Show("Вы не все взвесили и по этому не можете узнать всю стоимость.");
                        return 0;
                    }
                    else
                    {

                        cost += paket.totalCost;
                    }
                }
            else if (kvp.Key is Goods good) { cost += good.Price * kvp.Value; }
            }
           this.SummaPokupok = cost;
            MessageBox.Show($"{SummaPokupok} руб.");
           return cost;
        }

        public int ForcedCartCost() //сотрудники магаза сами определят на сколько вы набрали......
        {
            int cost = 0;
            foreach (var kvp in cartItems)
            {
                if (kvp.Key is Paketik paket)
                {
                    paket.weighAll();
                    cost += paket.totalCost;
                }
                else if (kvp.Key is Goods good) { cost += good.Price * kvp.Value; }
            }
            this.SummaPokupok = cost;
           
            return cost;
        }

       private void UpdateCartCost()
       {
           int cost = 0;
           foreach (var kvp in cartItems)
           {
               if (kvp.Key is Paketik paket)
               {
                   if (paket.totalCost > 0)
                   {
                       cost += paket.totalCost;
                   }
               }
               else if (kvp.Key is Goods good)
               {
                   cost += good.Price * kvp.Value;
               }
           }
       
           SummaPokupok = cost;
       }

        public void ClearCart()
        {
            cartItems.Clear(); 
        }
    }

        class Paketik : IpaketikAndGoods
        {
            public List<MeasurableGoods> PaketOvoshey = new List<MeasurableGoods>();
            public int ID { get; }
            public Paketik(int IDto, MeasurableGoods md) {
                ID = IDto;
                    PaketOvoshey.Add(md);
            }
            public float totalWeight;
            public int totalCost;
            public float weighAll()
            {
                if (!(PaketOvoshey.Count() > 0)) { return 0.0f; }
                else
                {
                    float totalWeight = 0.0f;
                    foreach (var item in PaketOvoshey)
                    {
                        totalWeight += item.Weigh();

                    }
                this.totalWeight = totalWeight;
                if (PaketOvoshey.Count > 0)
                    {
                        this.totalCost = (int)(Math.Ceiling(totalWeight*0.001f * PaketOvoshey[0].Price));
                    } else { MessageBox.Show("Вы взвешиваете пустой пакет..."); }
                   
                   
                    return totalWeight;
                }
            }

        }


}
