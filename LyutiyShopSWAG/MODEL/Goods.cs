using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    internal class Goods : IpaketikAndGoods
    {
        public int ID { get; protected set; }
        public string Name { get; set; }
        public int Price { get; protected set; }
        public bool IsMeasurable { get; protected set; }

        public Goods(int id, string name, int price, bool isMeasurable)
        {
            ID = id;
            Name = name;
            Price = price;
            IsMeasurable = isMeasurable;
        }

        public virtual string Description => $"{Name}, Цена: {Price} руб.";
    }

    internal class PackedGoods : Goods
    {
        public float FixedWeight { get; private set; }

        public PackedGoods(int id, string name, int price, float weight)
            : base(id, name, price, false)
        {
            FixedWeight = weight;
        }

        public override string Description =>
      $"{Name} (в упаковке, {FixedWeight} г), Цена: {Price} руб.";
    }

    internal class MeasurableGoods : Goods
    {
        public float? Weight { get; private set; } // null пока не взвешен
        public float WeightMin { get; private set; }
        public float WeightMax { get; private set; }

        private Random rnd = new Random();

        public MeasurableGoods(int id, string name, int price, float weightMin, float weightMax)
            : base(id, name, price, true)
        {
            WeightMin = weightMin;
            WeightMax = weightMax;
        }
        //взвешивание!!
        public float Weigh()
        {
            if (Weight == null)
            {
                Weight = (float)(rnd.NextDouble() * (WeightMax - WeightMin) + WeightMin);
            }
            
            return Weight.Value;
        }

        public override string Description =>
            Weight == null
                ? $"{Name} (вес: ???), Цена: {Price} руб."
                : $"{Name} (вес: {Weight:F2} г), Цена: {Price} руб.";
    }

    public interface IpaketikAndGoods { public int ID { get; } } //то есть у меня проосто создан интерфейс для объединения фигни

}
