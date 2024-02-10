namespace SecondConsoleApp.Events
{
    public class Sensor
    {
        public event EventHandler<TemperatureEventArgs> TemperatureLimitReached;
        Random random = new();

        public void SimulateTemperatureChange()
        {
            double temp = random.Next(1, 100);
            Console.WriteLine($"Currenct temperature: {temp}");

            if (temp > 80)
                TemperatureLimitReached.Invoke(this, new TemperatureEventArgs(temp));
        }

    }
}
