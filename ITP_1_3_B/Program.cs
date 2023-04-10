using System;

namespace ITP_1_3_B
{
    public class Program
    {
        static void Main()
        {
            int Count = 0;
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                
                Count++;
                Console.WriteLine($"Case {Count}: {x}");
                if (x == 0) break;
            } 

        }
    }
}
