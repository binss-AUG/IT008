using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;

namespace Bai02;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập vào giá trị n: ");
        int n = isInt(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Chỉ số n không hợp lệ!");
            return;
        }
        PrintList(n);
    }
    static void PrintList(int n)
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("1: Tính tổng các số nguyên tố bé hơn n: " + SumPrimeLessN(n));
        Console.WriteLine("-------------------------------------------------------------");
    }
    static int isInt(string s)
    {
        string maxVal = "1000000";

        if (maxVal.Length < s.Length) return -1;
        if (maxVal.Length == s.Length)
        {
            for(int i = 0;i < maxVal.Length;i++)
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
    static bool isPrime(int n)
    {
        if (n <= 1) return false;
        for(int i = 2;i <= Math.Sqrt(n);i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }

    static int SumPrimeLessN(int n)
    {
        int sum = 0;
        for(int i =2;i < n;i++)
        {
            if (isPrime(i)) sum += i; 
        }

        return sum;
    }
}
