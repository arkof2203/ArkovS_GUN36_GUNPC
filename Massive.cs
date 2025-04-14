namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int[][] array3 = new int[3][]
            {
                new[] { 2, 3, 4 },        // 2^1, 3^1, 4^1
                new[] { 4, 9, 16 },       // 2^2, 3^2, 4^2
                new[] { 8, 27, 64 }       // 2^3, 3^3, 4^3
            };

            double[][] jaggedarray = new double[3][];

            jaggedarray[0] = new double[] { 1, 2, 3, 4, 5 };

            jaggedarray[1] = new double[] { Math.E, Math.PI };

            jaggedarray[2] = new double[]
            {
            Math.Log10(1),
            Math.Log10(10),
            Math.Log10(100),
            Math.Log10(1000)
            };

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            Array.Resize(ref array, 10);

            Array.Copy(array, 0, array2, 0, 3);

            Console.WriteLine("Result:");

        }
    }
}