class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        if (!int.TryParse(Console .ReadLine(), out int a))
        {
            Console.WriteLine("Ошибка! Введено некорректное число.");
            return;
        }

        Console.WriteLine("Введите второе число");
        if (!int.TryParse(Console .ReadLine(), out int b))
        {
            Console.WriteLine("Ошибка! Введено некорректное число.");
            return;
        }

        Console.WriteLine("Введите знак (+, -, *, /, %):");
        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        {
            Console.WriteLine("Ошибка! Неверный ввод операции.");
            return;
        }

        switch (s[0])
        {
            case '+':
                Console.WriteLine("Результат {0} + {1} = {2}", a, b, a + b);
                break;
            case '-':
                Console.WriteLine("Результат {0} - {1} = {2}", a, b, a - b);
                break;
            case '*':
                Console.WriteLine("Результат {0} * {1} = {2}", a, b, a * b);
                break;
            case '/':
                Console.WriteLine("Результат {0} / {1} = {2}", a, b, a / b);
                break;
            case '%':
                Console.WriteLine("Результат {0} % {1} = {2}", a, b, a % b);
                break;
            default: 
                Console.WriteLine("Ошибка! Неизвестная операция.");
                break;

        }
    }
}