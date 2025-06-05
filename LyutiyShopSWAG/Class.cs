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

        public int SummaPokupok = 0;

        private Dictionary<Goods, CartItem> cartItems = new();
        private Random rnd = new Random();

        private ShoppingCart() { }

        public void AddProduct(Goods item, int count)
        {
            if (!cartItems.TryGetValue(item, out var cartItem))
            {
                cartItem = new CartItem(0);
                cartItems[item] = cartItem;
            }

            cartItem.Quantity += count;

            if (item is MeasurableGoods mg)
            {
                cartItem.Weights ??= new List<float>();

                for (int i = 0; i < count; i++)
                {
                    float weight = (float)(rnd.NextDouble() * (mg.WeightMax - mg.WeightMin) + mg.WeightMin);
                    cartItem.Weights.Add(weight);
                }
            }

            // ⬇️ Уменьшаем количество на складе
            Stellaj.current.ChangeAmount(item.Name, -count);

            MessageBox.Show($"Добавлено: {count} x {item.Description}");
        }


        public void RemoveProduct(Goods item, int count)
        {
            if (!cartItems.TryGetValue(item, out var cartItem))
            {
                MessageBox.Show("Товар не найден в корзине.");
                return;
            }

            int removedCount = count;

            if (count >= cartItem.Quantity)
            {
                removedCount = cartItem.Quantity;
                cartItems.Remove(item);
                MessageBox.Show($"Товар удалён из корзины: {item.Description}");
            }
            else
            {
                cartItem.Quantity -= count;

                if (item is MeasurableGoods && cartItem.Weights != null)
                {
                    int toRemove = Math.Min(count, cartItem.Weights.Count);
                    cartItem.Weights.RemoveRange(cartItem.Weights.Count - toRemove, toRemove);
                }

                MessageBox.Show($"Удалено: {count} x {item.Description}");
            }

            // ⬇️ Возвращаем товар на склад
            Stellaj.current.ChangeAmount(item.Name, removedCount);
        }


        public float WeighMeasurableProducts()
        {
            float totalWeight = 0;

            foreach (var kvp in cartItems)
            {
                if (kvp.Key is MeasurableGoods)
                {
                    var weights = kvp.Value.Weights;
                    if (weights != null)
                    {
                        float sum = weights.Sum();
                        MessageBox.Show($"{kvp.Key.Name}: {sum:F2} г ({weights.Count} шт.)");
                        totalWeight += sum;
                    }
                }
            }

            MessageBox.Show($"Общий вес всех измеряемых товаров: {totalWeight:F2} г");
            return totalWeight;
        }

        public string GetCartSummary()
        {
            if (cartItems.Count == 0)
                return "Корзина пуста.";

            var sb = new System.Text.StringBuilder();
            sb.AppendLine("Товары в корзине:");

            foreach (var pair in cartItems)
            {
                sb.Append($"- {pair.Key.Description} — {pair.Value.Quantity} шт.");

                if (pair.Key is MeasurableGoods && pair.Value.Weights != null)
                {
                    float sum = pair.Value.Weights.Sum();
                    sb.Append($" (вес: {sum:F2} г)");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

    class CartItem
    {
        public int Quantity { get; set; }
        public List<float>? Weights { get; set; } // только для MeasurableGoods

        public CartItem(int quantity)
        {
            Quantity = quantity;
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
}
