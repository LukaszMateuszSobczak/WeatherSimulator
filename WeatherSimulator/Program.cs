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
                } else
                {
                    weatherConditions[i] = conditions[random.Next(0, conditions.Length - 1)];
                }
            }

            foreach (int temp in temperatures)
            {
                Console.WriteLine(temp);
            }

            foreach(string weatherCondition in weatherConditions)
            {
                Console.WriteLine(weatherCondition);
            }

        }
    }
}
