using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input money: ");
            double money = double.Parse(Console.ReadLine());

            int A = 0;
            int B = 0;
            while (B + 1000 <= money)
            {
                if (B < money && money >= 1000)
    
                {
                    B += 1000;
                    A++;
                    if (B == money)
                        break;
                }
            }
            Console.WriteLine("1000: {0}", A);

                money -= A * 1000;
            int C = 0;
            int D = 0;
            while (D <= money)
            {
                if (D + 500 <= money)
                {
                    C++;
                }
                D += 500;
            }

            Console.WriteLine("500: {0}", C);

            money -= C * 500;
            int E = 0;
            int F = 0;
            while (F <= money)
            {
                if (F + 100 <= money)
                {
                    E++;
                }
                F += 100;
            }

            Console.WriteLine("100: {0}", E);

            money -= E * 100;
            int G = 0;
            int H = 0;
            while (H <= money)
            {
                if (H + 50 <= money)
                {
                    G++;
                }
                H += 50;
            }

            Console.WriteLine("50: {0}", G);

            money -= G * 50;
            int I = 0;
            int J = 0;
            while (J <= money)
            {
                if (J + 20 <= money)
                {
                    I++;
                }
                J += 20;
            }

            Console.WriteLine("20: {0}", I);

            money -= I * 20;
            int K = 0;
            int L = 0;
            while (L <= money)
            {
                if (L + 10 <= money)
                {
                    K++;
                }
                L += 10;
            }

            Console.WriteLine("10: {0}", K);

            money -= K * 10;
            int M = 0;
            int N = 0;
            while (N <= money)
            {
                if (N + 2 <= money)
                {
                    M++;
                }
                N += 2;
            }

            Console.WriteLine("2: {0}", M);

            money -= M * 2;
            int O = 0;
            int P = 0;
            while (P <= money)
            {
                if (P + 1 <= money)
                {
                    O++;
                }
                P += 1;
            }

            Console.WriteLine("1: {0}", O);

            money -= O * 1;
            double Q = 0;
            double R = 0;
            while (R <= money)
            {
                if (R + 0.50 <= money)
                {
                   Q++;
                }
                R += 0.50;
            }

            Console.WriteLine("0.50: {0}", Q);

            money -= Q * 0.50;
            double S = 0;
            double T = 0;
            while (T <= money)
            {
                if (T + 0.25 <= money)
                {
                    S++;
                }
                T += 0.25;
            }

            Console.WriteLine("0.25: {0}", S);


























            Console.ReadLine(); 
          
        }
    }
}
