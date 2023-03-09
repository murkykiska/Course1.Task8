using System;

namespace Task8 
{
    internal class Program
    {
        static void PrintDictionary(Dictionary<long, string> dictionary)
        {
            Console.WriteLine($"В словаре содержится {dictionary.Count} элементов.");
            Console.WriteLine("Номер телефона\t\tФИО");

            foreach (var x in dictionary)
            {
                Console.WriteLine($"{x.Key}\t\t{x.Value}");
            }
        }
        static void FindInDictionary(Dictionary<long, string> dictionary, long key)
        {
            string value;

            if (dictionary.TryGetValue(key, out value))
            {
                Console.WriteLine($"Найденная запись: {key}\t\t{value}");
            }
            else
            {
                Console.WriteLine("Данный номер отсутствует в словаре.");
            }
        }
        static void AddNewPerson(ref Dictionary<long, string> dictionary, long key)
        {
            Console.Write("Введите ФИО: ");

            dictionary[key] = Console.Read().ToString();
        }
        static void Main(string[] args)
        {
            long key;

            Dictionary<long, string> Persons = new Dictionary<long, string>()
            {
                [79001001010] = "Иванов Иван Иванович",
                [79132002020] = "Петров Петр Петрович"
            };

            while (true)
            {
                Console.WriteLine("Продолжайте итеративный ввод номера телефонов и ФИО их владельцев (первым идет ввод номера телефона)");
                Console.WriteLine("1 - для вывода всего содержимого в консоль");
                Console.WriteLine("2 - для поиска владельца по номеру телефона");
                Console.Write("Введите номер телефона или номер режима: ");

                string mode = Console.Read().ToString();

                if (long.TryParse(mode, out key))
                {
                    switch (mode)
                    {
                        case "1":
                            PrintDictionary(Persons);
                            break;
                        case "2":
                            FindInDictionary(Persons, key);
                            break;
                        default:
                            if (Persons.ContainsKey(key))
                            {
                                Console.WriteLine("Данный номер телефона уже зарегистрирован в сисеме.");
                            }
                            else
                            {
                                AddNewPerson(ref Persons, key);
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Было введено не число!");
                }
            }
        }
    }
}