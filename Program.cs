using System;

class Program
{
    static void Main(string[] args)
    {
        
        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        int product = 1;

        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введіть число {0}: ", i + 1);
            int number = Convert.ToInt32(Console.ReadLine());

            
            sum += number;
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            product *= number;
        }
        Console.WriteLine("Сума: " + sum);
        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Мінімум: " + min);
        Console.WriteLine("Добуток: " + product);
    }
}
