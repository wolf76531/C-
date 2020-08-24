using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;


namespace guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyin;  //user key in 猜的數字
            int[] guess = new int[4];  //電腦亂數產生的數字
            int count;  //猜了幾次
            int A;
            int B;
            Random r = new Random();

            for (int i = 0; i < guess.Length; i++)
            {
                guess[i] = r.Next(0, 10);
                for (int j = 0; j < i; j++)
                {
                    while (guess[j] == guess[i])
                    {
                        j = 0;
                        guess[i] = r.Next(0, 10);
                    }
                }
            }

            count = 0;  //初始化猜的次數



            while (true)
            {
                count++;
                A = 0;
                B = 0;
                Console.WriteLine("開始來猜數字");
                Console.WriteLine("請輸入數字:");
                keyin = Console.ReadLine();
                for (int i = 0; i < keyin.Length; i++)
                {
                    for (int j = 0; j < guess.Length; j++)
                    {
                        if (keyin.Substring(i, 1) == guess[j].ToString())
                        {
                            if (i == j)
                            {
                                A++;
                            }
                            else if (i != j)
                            {
                                B++;
                            }
                        }

                    }

                }

                if (A == 4)
                {
                    Console.WriteLine("恭喜答對了");
                    Console.WriteLine("共猜了{0}次", count);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}A{1}B", A, B);
                }
            }
        }
    }
}
