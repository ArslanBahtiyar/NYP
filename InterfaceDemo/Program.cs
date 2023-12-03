namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var worker in eats)
            {
                worker.Eat();
            }
        }
    }
}