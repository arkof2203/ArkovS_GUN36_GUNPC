namespace Classes
{
    public struct Interval
    {
        public float Min { get; }
        public float Max { get; }

        private static readonly Random _random = new Random();

        public Interval(int minValue, int maxValue)
        {
            if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Некорректные входные данные");
            }
            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Некорректные входные данные");
            }
            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine("Некорректные входные данные");
            }
            if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Некорректные входные данные");
            }

            Min = maxValue;
            Max = minValue;
        }

        public float Get()
        {
            return (float)(_random.NextDouble() * (Max - Min) + Min);
        }


    }


}