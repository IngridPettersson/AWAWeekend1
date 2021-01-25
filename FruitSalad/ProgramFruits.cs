using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitSalad
{
    class ProgramFruits
    {
        static string fruitName;
        static double fruitPrice;
        static List<Fruit> fruitList = new List<Fruit>();
        static Fruit fruit;
        static double maxValue;
        static double minValue;

        static void Main(string[] args)
        {
            AddFruitsToList();
            PrintOut();
            maxValue = GetMaxValue(fruitList);
            Console.WriteLine(maxValue);
            minValue = GetMinValue(fruitList);
            Console.WriteLine(minValue);
        }

        private static void AddFruitsToList()
        {
            for (int i = 0; i < 3; i++)
            {
            Console.Write("Enter a fruit: ");
            fruitName = Console.ReadLine();
            Console.Write("Enter price of fruit: ");
            fruitPrice = Convert.ToDouble(Console.ReadLine());

            fruit = new Fruit(fruitName, fruitPrice);
                fruitList.Add(fruit);
            }
        }

        private static void PrintOut()
        {
            foreach (Fruit fruit in fruitList)
            {
                Console.WriteLine($"\nFruit: {fruit.Name}\nPrice: {fruit.Price}\n");
            }
        }

        private static double GetMaxValue(List<Fruit> list)
        {
            maxValue = list.Max(r => r.Price);
            return maxValue;
        }

        private static double GetMinValue(List<Fruit> list)
        {
            minValue = list.Min(r => r.Price);
            return minValue;
        }
    }
}
