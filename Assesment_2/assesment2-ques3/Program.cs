using System;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        try
        {
            stopwatch.Start();
            TimeSpan duration1 = stopwatch.Stop();
            Console.WriteLine("Duration 1: " + duration1);

            stopwatch.Start();
            TimeSpan duration2 = stopwatch.Stop();
            Console.WriteLine("Duration 2: " + duration2);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
