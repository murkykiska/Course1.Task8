using System;
using System.Net;

namespace Task8 
{
    internal class Program
    {
        // Заполнение листа n случайными числами в диапазоне от 0 до 100
        static void InitializeList(ref List<int> list, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(0, 100));
            }
        }
        // Вывод листа в консоль
        static void PrintList(List<int> list)
        {
            Console.WriteLine($"\nЛист содержит {list.Count} элементов.\n");
            foreach (var x in list) 
            {
                Console.WriteLine(x);
            }
        }
        // Удаление чисел, которые больше числа value1, но меньше числа value2
        static void RemoveItems(ref List<int> list, int value1, int value2)
        {
            list.RemoveAll(x => x > value1 && x < value2);
        }
        static void Main(string[] args)
        {
            // Создайте лист целых чисел. 
            List<int> List = new List<int>();
            // Заполните лист 100 случайными числами в диапазоне от 0 до 100.
            InitializeList(ref List, 100);
            // Выведите коллекцию чисел на экран.
            PrintList(List);
            // Удалите из листа числа, которые больше 25, но меньше 50.
            RemoveItems(ref List, 25, 50);
            // Снова выведите числа на экран.
            PrintList(List);
        }
    }
}