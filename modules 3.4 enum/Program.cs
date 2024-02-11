namespace modules_3._4_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int semaphoreNumber = (int)Semaphore.yellow;
            Console.WriteLine( semaphoreNumber);
            
        }
    }

    enum Semaphore
    {
        red= 100, yellow= 100, green=300
    }
}
