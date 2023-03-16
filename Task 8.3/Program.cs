using System;

namespace Task8
{    
    internal class Program
    {
        static void PrintHashSet(HashSet<int> set)
        {
            Console.Write("HashSet: ");
            foreach (var item in set)
            {
                Console.Write($"{item}\t");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            string mode;
            int number;
            while (true)
            {
                Console.WriteLine("Продолжайте итеративный ввод чисел или выберите режим.");
                Console.WriteLine("print - Вывести все объекты Hashset-a.");

                mode = Console.ReadLine();

                switch (mode)
                {
                    case "print":
                        PrintHashSet(set);
                        break;
                    default:
                        if (int.TryParse(mode, out number))
                        {
                            if (set.Contains(number))
                                Console.WriteLine($"HashSet уже содержит число {number}.");
                            else
                            {
                                set.Add(number);
                                Console.WriteLine($"Число {number} сохранено.");
                            }
                                
                        }
                        else
                            Console.WriteLine("Было введено не число.");                                
                        break;                        
                }
            }
        }
    }
}