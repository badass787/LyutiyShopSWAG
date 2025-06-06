using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyutiyShopSWAG
{
    internal class Stellaj
    {
        // Количество товаров
        public int AmountTomato { get; private set; } = 0;
        public int AmountCucumber { get; private set; } = 0;
        public int AmountPotato { get; private set; } = 0;
        public int AmountCarrot { get; private set; } = 0;
        public int AmountOnion { get; private set; } = 0;
        public int AmountCabbage { get; private set; } = 0;
        public int AmountTomatoPacked { get; private set; } = 0;
        public int AmountCarrotPacked { get; private set; } = 0;
        public int AmountPotatoPacked { get; private set; } = 0;

        // Статические поля 
        public static string filePath = "C:\\Users\\Jopa\\source\\repos\\LyutiyShopSWAG\\LyutiyShopSWAG\\goods.csv";
        public static List<Goods> allGoods = new List<Goods>();
        private static readonly Stellaj _instance = new Stellaj();
        public static Stellaj Instance => _instance;

        Stellaj() { readDataFile(); }
        //Чтение из файла
        public int readDataFile()
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
                    this.setAmount(name, amount);
                    
                }
                else if (type == "measurable")
                {
                    float weightMin = float.Parse(parts[5]);
                    float weightMax = float.Parse(parts[6]);
                    var mg = new MeasurableGoods(id, name, price, weightMin, weightMax);
                    allGoods.Add(mg);
                    
                    this.setAmount(name, amount);
                    
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
                    lines.Add($"{g.ID},{g.Name},{g.Price},measurable,,{mg.WeightMin},{mg.WeightMax},{Instance.getAmount(g.Name)}");
                }
                else
                {
                    var pg = (PackedGoods)g;
                    lines.Add($"{g.ID},{g.Name},{g.Price},packed,{pg.FixedWeight},,,{Instance.getAmount(g.Name)}");
                }
            }

            File.WriteAllLines(filePath, lines);
            return 0;
        }

        //Получение количества по имени
        public int getAmount(string name)
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
        public void ChangeAmount(int ID, int delta)
        {
            switch (ID)
            {
                case 1:  if (AmountTomato <= 0) { MessageBox.Show("Вы забрали все помидоры..."); } else { AmountTomato += delta; } break;
                case 2: if (AmountCucumber <= 0) { MessageBox.Show("Вы забрали все огурцы..."); } else { AmountCucumber += delta; } break;
                case 3: if (AmountPotato <= 0) { MessageBox.Show("Вы забрали всю картошку..."); } else { AmountPotato += delta; } break;
                case 4: if (AmountCarrot <= 0) { MessageBox.Show("Вы забрали всю морковь..."); } else { AmountCarrot += delta; } break;
                case 5: if (AmountOnion <= 0) { MessageBox.Show("Вы забрали весь лук..."); } else { AmountOnion += delta; } break;
                case 6: if (AmountCabbage <= 0) { MessageBox.Show("Вы забрали всю капусту..."); } else { AmountCabbage += delta; } break;
                case 7: if (AmountTomatoPacked <= 0) { MessageBox.Show("Вы забрали все упаковки с томатами..."); } else { AmountTomatoPacked += delta; } break;
                case 9: if (AmountCarrotPacked <= 0) { MessageBox.Show("Вы забрали все упаковки с морковками..."); } else { AmountCarrotPacked += delta; } break;
                case 8: if (AmountPotatoPacked <= 0) { MessageBox.Show("Вы забрали все мешки с картошкой..."); } else { AmountPotatoPacked += delta; } break;
                default:
                    throw new ArgumentException($"Unknown product id: {ID}");
            }

            // Сохраняем изменения в файл
            writeDataFile();
        }
    }
}
