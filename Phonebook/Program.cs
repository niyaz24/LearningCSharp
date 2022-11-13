using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в PhoneBook.");
            Console.WriteLine("Какие функции вам поступны.");
            Console.WriteLine("1.Добавить контакт.");//не доделана сохранение нужно ещё подумать
            Console.WriteLine("2.Просмотр контактов.");//не доделал ещё 
            Console.WriteLine("3.Удалиние контактов.");//ещё не сделал
            Console.WriteLine("4.Поиск по имени.");
            Console.WriteLine("5.Поиск по номеру");
            var userInput = Console.ReadLine();
            var phonebook = new Phonebook();
            switch(userInput)
            {
                case "1":
                    Console.Write("Введите имя нового контакта:");
                    var name = Console.ReadLine();
                    Console.Write("Введите номер нового контакта:");
                    var number = Console.ReadLine();
                    var newAbonent = new Abonents(name, number);
                    phonebook.addAbonents(newAbonent);
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
            }
            Console.ReadKey();
        }
    }
    class Abonents
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Abonents (string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
    class Phonebook
    {
        /// <summary>
        /// добавляет контакт.
        /// </summary>
        private List<Abonents> _Abonents { get; set; }
        public void addAbonents(Abonents abonents)
        {
            _Abonents.Add(abonents);
        }
        /// <summary>
        /// Показывает все контакты.
        /// </summary>
        public void DisplayAllAbonents()
        {
            foreach (var abonents in _Abonents)
            {
                Console.WriteLine("Abonent:{0}, {1}", abonents.Name, abonents.Number);
            }
        }
        /// <summary>
        /// Ищет контакт по имени.
        /// </summary>
        /// <param name="name"></param>
        public void DisplayName(string SearchElements)//Ищет похожие элементы в имени контакта
        {
            var MathchingElements = _Abonents.Where(c => c.Name.Contains(SearchElements)).ToList();
            foreach (var abonents in MathchingElements)
            {
                Console.WriteLine("Abonent:{0}, {1}", abonents.Name, abonents.Number);
            }
        }
        /// <summary>
        ///Ищет контакт по номеру.
        /// </summary>
        /// <param name="number"></param>
        public void DisplayNumber(string number)
        {
            var abonents = _Abonents.FirstOrDefault(c => c.Number == number);
            if (abonents == null)
                Console.WriteLine("Нет такого контакта.");
            else
                Console.WriteLine("Abonent:{0}, {1}", abonents.Name, abonents.Number);
        }
    }
}
