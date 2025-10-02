using System;
namespace Bai02
{
    class Program
    {
        //Kiem tra so nguyen to
        static bool CheckSNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); ++i)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int sum = 0;
            for (int i = 2; i < n; ++i)
                if (CheckSNT(i))
                    sum += i;
            Console.WriteLine("Tong cac so nguyen to < {0}: {1}",n, sum);
        }
    }
}