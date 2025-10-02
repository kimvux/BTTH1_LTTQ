
using System;
using System.Data;
namespace Bai01
{
    class Program
    {
        //Kiem tra so nguyen to
        static bool CheckSNT(int x)
        {
            if (x < 2) return false;
            for (int i=2; i<= Math.Sqrt(x); ++i)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        //Kiem tra so chinh phuong
        static bool CheckSCP(int x)
        {
            double num = Math.Sqrt((double)x);
            if (x == num * num) return true;
            return false;
        }

        //Tinh to cac so le
        static int TongSoLe(int[] mang)
        {
            int Sumle = 0;
            foreach (int x in mang)
                if (x % 2 != 0) Sumle += x;
            return Sumle;
        }

        //Dem so luong so nguyen to
        static int SLSoNguyenTo(int[] mang)
        {
            int SL = 0;
            foreach (int x in mang)
                if (CheckSNT(x)) SL++;
            return SL;
        }

        //Tim so chinh phuong nho nhat
        static int SCPNhoNhat(int[] mang)
        {
            int index = -1;
            for (int i=0; i<mang.Length; ++i)
            {
                if (CheckSCP(mang[i])) index = i;
            }
            if (index == -1) return -1;
            for (int i = 0; i < mang.Length; ++i)
                if (CheckSCP(mang[i]) && mang[i] < mang[index])
                    index = i;
            return mang[index];
        }
        //Main
        static void Main()
        {
            Console.Write("Nhap vao n: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            int[] mang = new int[n];
            Random rd = new Random();

            for (int i=0 ; i<n ; i++)
                mang[i] = rd.Next(0,20);

            foreach (int x in mang)
                Console.Write(x + " ");
            Console.WriteLine();

            

            Console.WriteLine("1. Tong cac so le: " + TongSoLe(mang));
            Console.WriteLine("2. So luong so nguyen to: " + SLSoNguyenTo(mang));
            Console.WriteLine("3. So chinh phuong nho nhat: " + SCPNhoNhat(mang));


        }
    }
}