using System;
namespace Bai03
{
    class Program
    {
        static bool CheckNamNhuan(int x)
        {
            if ((x % 4 == 0 && x % 100 != 0) || x % 400 == 0) return true;
            return false;
        }
        static void Main()
        {
            while (true)
            {
                //Nhap va xu ly ngay thang nam
                Console.Write("Nhap vao ngay: ");
                string n = Console.ReadLine() ?? "";
                string[] Ngay = n.Split(new char[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);
                //Xuat ket qua
                Console.Write("---->");
                try
                {
                    //loi nhap co the xay ra
                    if (Ngay.Length != 3) throw new FormatException();
                    if (int.Parse(Ngay[0]) > 31 || int.Parse(Ngay[0]) < 1)
                        Console.WriteLine("Ngay ko hop le");
                    else if (int.Parse(Ngay[1]) > 12 || int.Parse(Ngay[1]) < 1)
                        Console.WriteLine("Thang ko hop le");
                    else
                    {
                        if (int.Parse(Ngay[1]) == 2)
                        {
                            if (CheckNamNhuan(int.Parse(Ngay[2])) == true)
                            {
                                if (int.Parse(Ngay[0]) > 29)
                                    Console.WriteLine("Ngay ko hop le");
                                else
                                    Console.WriteLine("Hop le");
                            }
                            else
                            {
                                if (int.Parse(Ngay[0]) > 28)
                                    Console.WriteLine("Ngay ko hop le");
                                else
                                    Console.WriteLine("Hop le");
                            }
                        }
                        else if (int.Parse(Ngay[1]) == 1 || int.Parse(Ngay[1]) == 3 || int.Parse(Ngay[1]) == 5 || int.Parse(Ngay[1]) == 7 || int.Parse(Ngay[1]) == 8 || int.Parse(Ngay[1]) == 10 || int.Parse(Ngay[1]) == 12)
                        {
                            if (int.Parse(Ngay[0]) > 31)
                                Console.WriteLine("Ngay ko hop le");
                            else
                                Console.WriteLine("Hop le");
                        }
                        else
                        {
                            if (int.Parse(Ngay[0]) > 30)
                                Console.WriteLine("Ngay ko hop le");
                            else
                                Console.WriteLine("Hop le");
                        }
                    }
                }
                //bat loi va yeu cau nhap lai
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai dinh dang!!!");
                }
                //em thử try catch lần đầu nên làm ko giống ai nha thầy :)
            }
        }
    }
}