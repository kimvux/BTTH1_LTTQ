using System;
namespace Bai06
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
        //Xuat ma tran
        static void XuatMT(int[,] arr)
        {
            for (int i=0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
        //Tim phan tu lon nhat/nho nhat
        static void TimMaxMin(int[,] arr)
        {
            int min = arr[0,0], max = arr[0,0];
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j] > max) max = arr[i, j];
                    if (arr[i, j] < min) min = arr[i, j];
                }      
            }
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
        //Tim dong co tong so lon nhat
        static void DongMaxTong(int[,] arr)
        {
            int dong = 1;
            int max = 0;
            for (int i = 0; i < arr.GetLength(1); ++i)
                max += arr[0, i];
            for (int i = 1; i < arr.GetLength(0); ++i)
            {
                int crmax = 0;
                for (int j = 0; j < arr.GetLength(1); ++j)
                    crmax += arr[i, j];
                if (crmax > max)
                {
                    max = crmax;
                    dong = i + 1;
                }
            }
            Console.WriteLine("Dong co tong lon nhat: " + dong);
        }
        //Tinh tong cac so khong phai so nguyen to
        static void TongSoKoPhaiSNT(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); ++i)
                for (int j=0; j < arr.GetLength(1); ++j)
                    if (CheckSNT(arr[i, j]) == false)
                        sum += arr[i, j];
            Console.WriteLine("Tong cac so ko phai so nguyen to: " + sum);
        }
        //Xoa dong thu K
        static void XoaDongK(ref int[,] arr,int k)
        {
            if (k - 1 > arr.GetLength(0)) return;
            int[,] newarr = new int[arr.GetLength(0)-1, arr.GetLength(1)];
            int i;
            for (i = 0; i < arr.GetLength(0); ++i)
            {
                if (i == k - 1)
                    break;
                for (int j = 0; j < arr.GetLength(1); ++j)
                    newarr[i, j] = arr[i, j];
            }

            for (; i < newarr.GetLength(0); ++i)
                for (int j = 0; j < newarr.GetLength(1); ++j)
                    newarr[i, j] = arr[i + 1, j];
            arr = newarr;
        }
        //Xoa cot chua phan tu lon nhat
        static void XoaCotChuaPhanTuLonNhat(ref int[,] arr)
        {
            int cot = 0;
            int max = arr[0, 0];
            for (int i=0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i,j] > max)
                    {
                        max = arr[i, j];
                        cot = j;
                    }
                }
            }
            int[,] newarr = new int[arr.GetLength(0), arr.GetLength(1) - 1];
            int x = 0;
            for (int i = 0; i < newarr.GetLength(0); ++i)
            {
                for (int j = 0; j < newarr.GetLength(1); ++j)
                {
                    if (j == cot) x = 1;
                    newarr[i, j] = arr[i, j + x];
                }
                x = 0;
            }
            arr = newarr;
        }
        //Main
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Nhap m: ");
            int m = int.Parse(Console.ReadLine() ?? "1");
            int[,] arr = new int[n,m];
            Random rd = new Random();
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    arr[i,j] = rd.Next(0, 100);

            Console.WriteLine("Xuat ma tran:");
            Console.WriteLine();
            XuatMT(arr);
            Console.WriteLine();
            TimMaxMin(arr);
            Console.WriteLine();
            DongMaxTong(arr);
            Console.WriteLine();
            TongSoKoPhaiSNT(arr);

            Console.Write("\nNhap dong K: ");
            int k = int.Parse(Console.ReadLine() ?? "0");
            XoaDongK(ref arr, k);
            Console.WriteLine("Xoa dong thu K:");
            XuatMT(arr);

            Console.WriteLine();
            Console.WriteLine("Xoa cot co phan tu lon nhat:");
            XoaCotChuaPhanTuLonNhat(ref arr);
            XuatMT(arr);
        }
    }
}