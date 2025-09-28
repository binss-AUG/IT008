using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;

namespace Bai04;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập vào tháng: ");
        int mm = int.Parse(Console.ReadLine());
        Console.Write("Nhập vào năm: ");
        int yy = int.Parse(Console.ReadLine());

        PrintList(mm, yy);
    }
    static void PrintList(int mm, int yy)
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("1: Tháng " + mm + "/" + yy + " co " + DaysOfMonth(mm, yy) + " ngày");
        Console.WriteLine("-------------------------------------------------------------");
    }
    static bool isLeap(int yy)
    {
        if ((yy % 4 == 0 && yy % 100 != 0) || (yy % 400 == 0)) return true;
        return false;
    }
    static int DaysOfMonth(int mm, int yy)
    {
        if (yy <= 0) return -1;
        if (mm < 1 || mm > 12) return -1;
        int[] Date = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (isLeap(yy)) Date[2]++;
        return Date[mm];
    }
}
