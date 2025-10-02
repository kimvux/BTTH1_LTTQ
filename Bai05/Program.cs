using System;
namespace Bai05
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Nhap ngay: ");
                string n = Console.ReadLine() ?? "";
                string[] Ngay = n.Split(new char[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);
                Console.Write("---->");
                //bat loi
                try
                {
                    DateTime today = new DateTime(int.Parse(Ngay[2]), int.Parse(Ngay[1]), int.Parse(Ngay[0]));
                    DayOfWeek x = today.DayOfWeek;
                    Console.WriteLine(x);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Nhap sai dinh dang!!!");
                }
            }
        }
    }
}