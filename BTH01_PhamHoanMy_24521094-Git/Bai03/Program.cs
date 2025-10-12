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
        int dd = isInt(Console.ReadLine());
        Console.Write("Nhập vào tháng: ");
        int mm = isInt(Console.ReadLine());
        Console.Write("Nhập vào năm: ");
        int yy = isInt(Console.ReadLine());

        PrintList(dd,mm,yy);
    }
    static void PrintList(int dd, int mm, int yy)
    {
        string res = (Check(dd, mm, yy)) ? "" : "không";
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("1: Ngày " + dd + "/" + mm + "/" + yy + " " + res + " hợp lệ!");
        Console.WriteLine("-------------------------------------------------------------");
    }
    static int isInt(string s)
    {
        string maxVal = "1000000";

        if (maxVal.Length < s.Length) return -1;
        if (maxVal.Length == s.Length)
        {
            for (int i = 0; i < maxVal.Length; i++)
            {
                if (maxVal[i] < s[i]) return -1;
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (!('0' <= s[i] && s[i] <= '9')) return -1;
        }

        return int.Parse(s);
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
