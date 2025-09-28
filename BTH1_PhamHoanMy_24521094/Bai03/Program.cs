using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;

namespace Bai03;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập vào ngày: ");
        int dd = int.Parse(Console.ReadLine());
        Console.Write("Nhập vào tháng: ");
        int mm = int.Parse(Console.ReadLine());
        Console.Write("Nhập vào năm: ");
        int yy = int.Parse(Console.ReadLine());

        PrintList(dd,mm,yy);
    }
    static void PrintList(int dd, int mm, int yy)
    {
        string res = (Check(dd, mm, yy)) ? "" : "không";
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("1: Ngày " + dd + "/" + mm + "/" + yy + " " + res + " hợp lệ!");
        Console.WriteLine("-------------------------------------------------------------");
    }
    static bool isLeap(int yy)
    {
        if ((yy % 4 == 0 && yy % 100 != 0) || (yy % 400 == 0)) return true;
        return false;
    }
    static bool Check(int dd, int mm, int yy)
    {
        if (yy <= 0) return false;
        if (mm < 1 || mm > 12) return false;
        int[] Date = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (isLeap(yy)) Date[2]++;

        if (dd < 1 || dd > Date[mm]) return false;
        return true;
    }
}
