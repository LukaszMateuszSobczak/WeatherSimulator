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
            Console.WriteLine($"Te max temperature was: {temperatures.Max()}");
            Console.WriteLine($"The min temperature was: {temperatures.Min()}");

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
