class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number");
        if (!int.TryParse(Console .ReadLine(), out int a))
        {
            Console.WriteLine("Error! Invalid number.");
            return;
        }

        Console.WriteLine("Enter the second number");
        if (!int.TryParse(Console .ReadLine(), out int b))
        {
            Console.WriteLine("Error! Invalid number.");
            return;
        }

        Console.WriteLine("Enter bitwise operator & | ^ + - / % *");
        var s = Console.ReadLine();
        if (s.Length == 0 || s.Length > 1)
        {
            Console.WriteLine("Error! Invalid operator.");
            return;
        }

        switch (s[0])
        {
            case '&':
                Console.WriteLine("Result {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine(Convert.ToString(a & b, 2));
                Console.WriteLine(Convert.ToString(a & b, 16));
                break;
            case '|':
                Console.WriteLine("Result {0} | {1} = {2}", a, b, a | b);
                Console.WriteLine(Convert.ToString(a | b, 2));
                Console.WriteLine(Convert.ToString(a | b, 16));
                break;
            case '^':
                Console.WriteLine("Result {0} ^ {1} = {2}", a, b, a ^ b);
                Console.WriteLine(Convert.ToString(a ^ b, 2));
                Console.WriteLine(Convert.ToString(a ^ b, 16));
                break;
            case '/':
                Console.WriteLine("Result {0} / {1} = {2}", a, b, a / b);
                break;
            case '%':
                Console.WriteLine("Result {0} % {1} = {2}", a, b, a % b);
                break;
            case '+':
                Console.WriteLine("Result {0} + {1} = {2}", a, b, a + b);
                break;
            case '-':
                Console.WriteLine("Result {0} - {1} = {2}", a, b, a - b);
                break;
            case '*':
                Console.WriteLine("Result {0} * {1} = {2}", a, b, a * b);
                break;
            default: 
                Console.WriteLine("Error! Unknown operation.");
                break;

        }
    }
}