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
                    while (true)
                    {
                        Console.WriteLine("Введите оценку студента (от 2 до 5):");
                        gradeInput = Console.ReadLine();
                        if (gradeInput == "exit") return;

                        if (int.TryParse(gradeInput, out grade) && grade >= 2 && grade <= 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Оценка должна быть числом от 2 до 5.");
                        }
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

        private class LinkedListTask
        {
            private class Node
            {
                public string Data;
                public Node Next;
                public Node Prev;

                public Node(string data)
                {
                    Data = data;
                }
            }

            private Node _head;
            private Node _tail;

            public void TaskLoop()
            {
                Console.WriteLine("Task 3: Работа с двусвязным списком.");
                Console.WriteLine("Для выхода введите 'exit' в любое время.");
                Console.WriteLine("Введите от 3 до 6 элементов:");

                int count = 0;
                while (count < 6)
                {
                    string input = Console.ReadLine();
                    if (input == "exit") return;

                    AddLast(input);
                    count++;

                    if (count >= 3)
                    {
                        Console.WriteLine("Хотите закончить ввод? (да/нет)");
                        string answer = Console.ReadLine();
                        if (answer == "exit") return;
                        if (answer.ToLower() == "да")
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine("Список в прямом порядке:");
                PrintForward();

                Console.WriteLine("Список в обратном порядке:");
                PrintBackward();
            }

            private void AddLast(string data)
            {
                Node newNode = new Node(data);
                if (_head == null)
                {
                    _head = _tail = newNode;
                }
                else
                {
                    _tail.Next = newNode;
                    newNode.Prev = _tail;
                    _tail = newNode;
                }
            }

            private void PrintForward()
            {
                Node current = _head;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }

            private void PrintBackward()
            {
                Node current = _tail;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Prev;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание для проверки: 1, 2 или 3");
            if (int.TryParse(Console.ReadLine(), out int task))
            {
                switch (task)
                {
                    case 1:
                        CheckTaskFirst();
                        break;
                    case 2:
                        CheckTaskSecond();
                        break;
                    case 3:
                        CheckTaskThird();
                        break;
                    default:
                        Console.WriteLine("Неверный номер задачи.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода числа.");
            }
        }

        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }

        private static void CheckTaskSecond()
        {
            var dictTask = new DictionaryTask();
            dictTask.TaskLoop();
        }

        private static void CheckTaskThird()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}
