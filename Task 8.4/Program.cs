using System;
using System.Xml.Linq;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "persons.xml";

            XDocument xdoc = (File.Exists(fileName)) ? XDocument.Load(fileName) : new XDocument();

            // создаем элемент Person
            XElement person = new XElement("Person");

            // Создаем атрибут ФИО
            Console.WriteLine("Введите ФИО:");
            XAttribute fio = new XAttribute("ФИО", Console.ReadLine());
            person.Add(fio);

            // Создаем элемент Adress
            XElement addr = new XElement("Address");

            // Заполняем элемент Address
            Console.WriteLine("Введите название улицы:");
            XElement street = new XElement("Street", Console.ReadLine());
            addr.Add(street);

            Console.WriteLine("Введите номер дома:");
            XElement houseNumber = new XElement("HouseNumber", Console.ReadLine());
            addr.Add(houseNumber);

            Console.WriteLine("Введите номер квартиры:");
            XElement flatNumber = new XElement("FlatNumber", Console.ReadLine());
            addr.Add(flatNumber);

            // Добавляем элемент Address в элемент Person
            person.Add(addr);

            // Создаем элемент Phones
            XElement phones = new XElement("Phones");

            // Заполняем элемент Phones
            Console.WriteLine("Введите номер мобильного телефона:");
            XElement mobilePhone = new XElement("MobilePhone", Console.ReadLine());
            phones.Add(mobilePhone);

            Console.WriteLine("Введите номер домашнего телефона:");
            XElement flatPhone = new XElement("FlatPhone", Console.ReadLine());
            phones.Add(flatPhone);

            // Добавляем элемент Phones в элемент Person
            person.Add(phones);

            xdoc.Add(person);

            xdoc.Save(fileName);

            Console.WriteLine("Контакт сохранен");
        }
    }
}