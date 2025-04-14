namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[10] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            for (int index = 0; index < fibonacci.Length; index++)
            {
                Console.WriteLine(fibonacci[index]);
            }
            for (int index = 2; index <= 20; index += 2)
            {
                Console.WriteLine(index);
            }
            for(int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine(i * j);
                }
                Console.WriteLine();
            }

            string password = "qwerty";
            string userInput;

            Console.WriteLine("Enter the password:");

            do
            {
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int result))
                {
                    Console.WriteLine("Stop chating");
                    continue;
                }

                if (userInput != password)
                {
                    Console.WriteLine("Invalid password. Try again.");
                }

            } while (userInput != password);

            Console.WriteLine("Access is allowed!");

        }


    }
}

