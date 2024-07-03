namespace ObserverPatternPoC.Observers
{
    public class ConsoleObserver : IObserver
    {
        public void Update(string data)
        {
            Console.WriteLine($"Data received: {data}");
        }
    }
}