// Queue, pointers, bubble sort
using BSBO_0102_2021_lab1;
using System;
class Program
{
    static void Main(string[] args)
    {
        Queue q = new Queue();
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            q.Push(random.Next(0,100));
        }
        q.Print();
        for (int i = 0; i < 5; i++)
        {
            bool flag = false;
            for (int j = 0; j < 4-i; ++j)
            {
                int a = q.Get(j), b = q.Get(j + 1);
                if (a > b)
                {
                    flag = true;
                    q.Set(j + 1, a);
                    q.Set(j, b);
                }
            }
            if (!flag)
            {
                break;
            }
        }
        Console.WriteLine();
        q.Print();
    }
}