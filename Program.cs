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

                Console.WriteLine("Task 2: Работа со словарем студентов с их средними оценками");
                Console.WriteLine("Для выхода введите exit");
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("Введите имя студента:");
                    string name = Console.ReadLine();
                    if (name == "exit") return;

                    Console.WriteLine("Введите оценку студента от 2 до 5");
                    string gradeInput = Console.ReadLine();
                    if (gradeInput == "exit") return;

                    if (int.TryParse(gradeInput, out int grade) && grade >= 2 && grade <= 5)
                    {
                        _students[name] = grade;
                        Console.WriteLine("Добавлено: {name} с оценкой {grade}.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Оценка должна быть числом от 2 до 5");

                    }

                    Console.WriteLine("Хотите найти оценку студента? (да/нет)");
                    string answer = Console.ReadLine();
                    if (answer == "exit") return;

                    if (answer.ToLower() == "да")
                    {
                        Console.WriteLine("Введите имя студента для поиска:");
                        string searchName = Console.ReadLine();
                        if (searchName == "exit") return;

                        if (_students.TryGetValue(searchName, out int foundGrade))
                        {
                            Console.WriteLine("{searchName} имеет оценку {foundGrade}.");
                        }
                        else
                        {
                            Console.WriteLine("Студент с именем {searchName} не найден.");
                        }
                    }



                }
            }
    }
}