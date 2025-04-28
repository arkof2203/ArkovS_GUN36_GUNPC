using System;
using System.Collections.Generic;


namespace HomeWork
{

    internal class Program
    {
        private class ListTask
        {
            private readonly List<string> _listOfStrings = new List<string>();

            public void TaskLoop()
            {

                Console.WriteLine("Task 1: Работа со списком строк.");
                Console.WriteLine("Для выхода введите exit");
                Console.WriteLine();

                _listOfStrings.Add("Первый элемент");
                _listOfStrings.Add("Второй элемент");
                _listOfStrings.Add("Третий элемент");

                Console.WriteLine("Введите новою строку");
                string input = Console.ReadLine();
                if (input == "exit") return;
                _listOfStrings.Add(input);

                Console.WriteLine("Введите ещё одну строку для добавления в середину списка");
                input = Console.ReadLine();
                if (input == "--exit") return;
                int middleIndex = _listOfStrings.Count / 2;
                _listOfStrings.Insert(middleIndex, input);

                foreach (var str in _listOfStrings)
                {
                    Console.WriteLine(str);
                }
            }

        }

        private class DictionaryTask
        {
            private readonly List<string, int> _listOfStrings = new List<string, int>();

            public void TaskLoop()
            {

                Console.WriteLine("Task 1: Работа со списком строк.");
                Console.WriteLine("Для выхода введите exit");
                Console.WriteLine();

            }
        }
    }
}