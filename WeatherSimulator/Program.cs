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
            Console.WriteLine($"Most common condition was: {MostCommonCondition(weatherConditions)}");

        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[i] == conditions[j])
                    {
                        tempCount++;
                    }
                }
                if (count < tempCount)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }

        static int MinTemperature(int[] tempartures)
        {
            int min = tempartures[0];

            foreach (int temperature in tempartures)
            {
                if (min > temperature) min = temperature;
            }
            return min;
        }

        static int MaxTemperature(int[] tempartures)
        {
            int max = tempartures[0];
            foreach (int temperature in tempartures)
            {
                if (max < temperature) max = temperature;
            }
            return max;
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
