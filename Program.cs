using System;

class Program
{
    static void Main()
    {
        int rows;
        rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Pascal's triangle"); 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int val = 1;
                for (int k = 1; k <= rows - i; k++)
                {
                    val *= (i - j + k) / k;
                }
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
