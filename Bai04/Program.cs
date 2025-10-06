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
        int mm = isInt(Console.ReadLine());
        Console.Write("Nhập vào năm: ");
        int yy = isInt(Console.ReadLine());

        PrintList(mm, yy);
    }
    static void PrintList(int mm, int yy)
    {
        Console.WriteLine("-------------------------------------------------------------");
        int _res = DaysOfMonth(mm, yy);
        if (_res == -1)
        {
            Console.WriteLine("1: Tháng " + mm + "/" + yy + " " + " không hợp lệ!");
        }
        else
        {
            Console.WriteLine("1: Tháng " + mm + "/" + yy + " co " + DaysOfMonth(mm, yy) + " ngày");
        }
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
            if (s[i] == '.') return -1;
            if (s[i] == '-') return -1;
            if (!('0' <= s[i] && s[i] <= '9')) return -1;
        }

        return int.Parse(s);
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
