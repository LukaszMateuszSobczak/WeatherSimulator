namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperatures = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-25, 41);
                if (temperatures[i] >= 2)
                {
                    weatherConditions[i] = conditions[random.Next(0, conditions.Length - 2)];
                }
                else
                {
                    weatherConditions[i] = conditions[random.Next(0, conditions.Length - 1)];
                }
            }

            Console.WriteLine($"Average temperature is: {AverageTemperature(temperatures)}");

            LogTemperatures(temperatures);
            LogWetherCondition(weatherConditions);
            Console.WriteLine($"The max temperature by my method is: {MaxTemperature(temperatures)}");
            Console.WriteLine($"Te max temperature was: {temperatures.Max()}");
            Console.WriteLine($"The min temperature by my method is: {MinTemperature(temperatures)}");
            Console.WriteLine($"The min temperature was: {temperatures.Min()}");

        }

        static int MinTemperature(int[] tempartures)
        {
            int tmp = 0;

            foreach (int temperature in tempartures)
            {
                if (tmp > temperature) tmp = temperature;
            }
            return tmp;
        }

        static int MaxTemperature(int[] tempartures)
        {
            int tmp = 0;
            foreach (int temperature in tempartures)
            {
                if (tmp < temperature) tmp = temperature;
            }
            return tmp;
        }
        static double AverageTemperature(int[] temperatures)
        {
            int sum = 0;
            foreach (int temperature in temperatures)
            {
                sum += temperature;
            }

            return (double)sum / temperatures.Length;
        }

        static void LogTemperatures(int[] temperatures)
        {
            foreach (int temperature in temperatures)
            {
                Console.WriteLine($"Temperature: {temperature} celsius");
            }
        }

        static void LogWetherCondition(string[] weatherCondition)
        {
            foreach(string condition in weatherCondition)
            {
                Console.WriteLine($"Weather: {condition}");
            }
        }
    }
}
