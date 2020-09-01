using System;

public class Exercise33
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput integer:");
        int x = Convert.ToInt32(Console.ReadLine());

        for (x = 1; x <100; x++)



        {
            if (x % 3==0)
                {

                Console.WriteLine("multiple of 3 : {0}", x);

            }

        }
    }
}
