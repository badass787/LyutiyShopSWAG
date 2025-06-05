using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    internal class Goods
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
        public float Weight { get; set; }
        public float WeightMin { get; private set; }
        public float WeightMax { get; private set; }

        public MeasurableGoods(int id, string name, int price, float weightMin, float weightMax)
            : base(id, name, price, true)
        {
            WeightMin = weightMin;
            WeightMax = weightMax;
        }

        public override string Description =>
        $"{Name} (вес от {WeightMin} до {WeightMax} г), Цена: {Price} руб.";
    }


    ////
    ///
    //

    internal class Stellaj
    {
        // Количество товаров
        public int AmountTomato { get; private set; }
        public int AmountCucumber { get; private set; }
        public int AmountPotato { get; private set; }
        public int AmountCarrot { get; private set; }
        public int AmountOnion { get; private set; }
        public int AmountCabbage { get; private set; }
        public int AmountTomatoPacked { get; private set; }
        public int AmountCarrotPacked { get; private set; }
        public int AmountPotatoPacked { get; private set; }

        // Статические поля 
        public static string filePath = "goods.csv";
        public static List<Goods> allGoods = new List<Goods>();
        public static Stellaj current = new Stellaj();

        // Конструктор
        public Stellaj()
        {
            readDataFile();
        }

        //Чтение из файла
        public static int readDataFile()
        {
            if (!File.Exists(filePath))
                return -1;

            var lines = File.ReadAllLines(filePath);
            allGoods.Clear();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                int id = int.Parse(parts[0]);
                string name = parts[1];
                int price = int.Parse(parts[2]);
                string type = parts[3];
                int amount = int.Parse(parts[7]);

                if (type == "packed")
                {
                    float weight = float.Parse(parts[4]);
                    var pg = new PackedGoods(id, name, price, weight);
                    allGoods.Add(pg);
                    current.setAmount(name, amount);
                }
                else if (type == "measurable")
                {
                    float weightMin = float.Parse(parts[5]);
                    float weightMax = float.Parse(parts[6]);
                    var mg = new MeasurableGoods(id, name, price, weightMin, weightMax);
                    allGoods.Add(mg);
                    current.setAmount(name, amount);
                }
            }

            return 0;
        }

        //Запись в файл
        public static int writeDataFile()
        {
            var lines = new List<string>();

            foreach (var g in allGoods)
            {
                if (g.IsMeasurable)
                {
                    var mg = (MeasurableGoods)g;
                    lines.Add($"{g.ID},{g.Name},{g.Price},measurable,,{mg.WeightMin},{mg.WeightMax},{current.getAmount(g.Name)}");
                }
                else
                {
                    var pg = (PackedGoods)g;
                    lines.Add($"{g.ID},{g.Name},{g.Price},packed,{pg.FixedWeight},,,{current.getAmount(g.Name)}");
                }
            }

            File.WriteAllLines(filePath, lines);
            return 0;
        }

        //Получение количества по имени
        private int getAmount(string name)
        {
            return name switch
            {
                "Tomato" => AmountTomato,
                "Cucumber" => AmountCucumber,
                "Potato" => AmountPotato,
                "Carrot" => AmountCarrot,
                "Onion" => AmountOnion,
                "Cabbage" => AmountCabbage,
                "Tomato Packed" => AmountTomatoPacked,
                "Carrot Packed" => AmountCarrotPacked,
                "Potato Packed" => AmountPotatoPacked,
                _ => 0
            };
        }

        //Установка количества по имени
        private void setAmount(string name, int amount)
        {
            switch (name)
            {
                case "Tomato": AmountTomato = amount; break;
                case "Cucumber": AmountCucumber = amount; break;
                case "Potato": AmountPotato = amount; break;
                case "Carrot": AmountCarrot = amount; break;
                case "Onion": AmountOnion = amount; break;
                case "Cabbage": AmountCabbage = amount; break;
                case "Tomato Packed": AmountTomatoPacked = amount; break;
                case "Carrot Packed": AmountCarrotPacked = amount; break;
                case "Potato Packed": AmountPotatoPacked = amount; break;
            }
        }

        //Изменение количества товара
        public void ChangeAmount(string name, int delta)
        {
            switch (name)
            {
                case "Tomato": AmountTomato += delta; break;
                case "Cucumber": AmountCucumber += delta; break;
                case "Potato": AmountPotato += delta; break;
                case "Carrot": AmountCarrot += delta; break;
                case "Onion": AmountOnion += delta; break;
                case "Cabbage": AmountCabbage += delta; break;
                case "Tomato Packed": AmountTomatoPacked += delta; break;
                case "Carrot Packed": AmountCarrotPacked += delta; break;
                case "Potato Packed": AmountPotatoPacked += delta; break;
                default:
                    throw new ArgumentException($"Unknown product name: {name}");
            }

            // Сохраняем изменения в файл
            writeDataFile();
        }
    }

}
