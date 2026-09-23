namespace ConsoleApp2
{
    using System;

    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("1. 1~100 짝수");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("2. 1~10 출력");

            int a = 1;

            while (a <= 10)
            {
                Console.Write(a + " ");
                a++;
            }

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("3. 1~100 홀수");

            int b = 1;

            do
            {
                if (b % 2 == 1)
                {
                    Console.Write(b + " ");
                }

                b++;
            }
            while (b <= 100);

            Console.WriteLine();
            Console.WriteLine();


            
            Console.WriteLine("4. 별 피라미드");

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();


            Console.WriteLine("5. 숫자 5개 입력");

            int min = 0;
            int max = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자 입력: ");
                int num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    min = num;
                    max = num;
                }
                else
                {
                    if (num < min)
                    {
                        min = num;
                    }

                    if (num > max)
                    {
                        max = num;
                    }
                }
            }

            Console.WriteLine("최솟값: " + min);
            Console.WriteLine("최댓값: " + max);
        }
    }
}
