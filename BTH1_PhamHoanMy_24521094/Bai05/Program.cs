using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;

namespace Bai05;

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

        PrintList(dd, mm, yy);
    }
    static void PrintList(int dd, int mm, int yy)
    {   
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Chọn mốc 1/1/1 là thứ 2 :v");
        int keyres = DayOfWeek(dd, mm, yy);
        string[] resArr = { "chủ nhật", "thứ hai", "thứ ba", "thứ tư", "thứ năm", "thứ sáu", "thứ bảy", "không hợp lệ" };
        Console.WriteLine("1: Ngày " + dd + "/" + mm + "/" + yy + " là ngày " + resArr[keyres]);
        Console.WriteLine("-------------------------------------------------------------");
    }

    static bool isLeap(int yy)
    {
        if ((yy % 4 == 0 && yy % 100 != 0) || (yy % 400 == 0)) return true;
        return false;
    }
    static int DayOfWeek(int dd, int mm, int yy)
    {
        if (yy <= 0) return 7;
        if (mm < 1 || mm > 12) return 7;
        int[] Date = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (isLeap(yy)) Date[2]++;

        if (dd < 1 || dd > Date[mm]) return 7;

        int SumofDay = 0;

        SumofDay += (dd % 7);

        for (int i = 1; i < mm; i++) SumofDay += (Date[i] % 7);

        SumofDay += yy - 1 + yy / 4 - yy / 100 + yy / 400;
        //for (int i = 1; i < yy; i++)
        //{
        //    SumofDay += (isLeap(i) ? 2 : 1);
        //}
        return SumofDay % 7;
    }
}
