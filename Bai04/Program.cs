using System;
namespace Bai04
{
    class Program
    {
        //Kiem tra nam nhuan
        static bool CheckNamNhuan(int x)
        {
            if ((x % 4 == 0 && x % 100 != 0) || x % 400 == 0) return true;
            return false;
        }
        static void Main()
        {
            while (true)
            {
                //Nhap va xu li thang nam
                Console.Write("Nhap vao thang va nam: ");
                string n = Console.ReadLine() ?? "";
                string[] Ngay = n.Split(new char[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);
                //Xuat ket qua
                Console.Write("---->");
                try
                {
                    if (int.Parse(Ngay[0]) < 1 || int.Parse(Ngay[0]) > 12) throw new Exception();
                    if (Ngay.Length > 2) throw new FormatException();
                    if (Ngay.Length < 2) throw new IndexOutOfRangeException();

                    if (int.Parse(Ngay[0]) == 2)
                    {
                        if (CheckNamNhuan(int.Parse(Ngay[1])) == true)
                            Console.WriteLine("29 ngay");
                        else
                            Console.WriteLine("28 ngay");
                    }
                    else if (int.Parse(Ngay[0]) == 1 || int.Parse(Ngay[0]) == 3 || int.Parse(Ngay[0]) == 5 || int.Parse(Ngay[0]) == 7 || int.Parse(Ngay[0]) == 8 || int.Parse(Ngay[0]) == 10 || int.Parse(Ngay[0]) == 12)
                        Console.WriteLine("31 ngay");
                    else
                        Console.WriteLine("30 ngay");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai dinh dang!!!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Vui long nhap day du!!!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Thang ko hop le!!!");
                }
            }
        }
    }
}