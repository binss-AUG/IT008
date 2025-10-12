using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;

namespace Bai01;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập vào kích thước n của mảng: ");
        int n = isInt(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Chỉ số n không hợp lệ!");
            return;
        }
        int[] arr = new int[n];

        InputArr(arr, n);

        PrintList(arr, n);

    }
    static void PrintList(int[] arr, int n)
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("1: Tính tổng các số lẻ trong mảng: "  + OddSum(arr, n));
        Console.WriteLine("2: Đếm số nguyên tố trong mảng: " + PrimeCount(arr, n));
        Console.WriteLine("3: Tìm số chính phương nhỏ nhất (nếu không có hàm trả về -1): " + MinSquareNum(arr,n));
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
    static void InputArr(int[] arr, int n)
    {
        Console.Write("Sinh các giá trị: ");
        Random rand = new Random();
        for(int i = 0;i < n;i++)
        {

            arr[i] = rand.Next(-100,100);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static int OddSum(int[] arr, int n)
    {
        int sum = 0;
        for(int i = 0;i < n;i++)
        {
            if (Math.Abs(arr[i]) % 2 == 1) sum += arr[i];
        }

        return sum;
    }
    static bool isPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
    static int PrimeCount(int[] arr, int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (isPrime(arr[i]))
            {
                count++;
            }
        }
        return count;
    }
    static bool isSquareNum(int n)
    {
        if (n < 0) return false;
        int temp = (int)Math.Sqrt(n);
        return (Math.Pow(temp, 2) == n);
    }
    static int MinSquareNum(int[] arr, int n)
    {
        bool used = false;
        int res = -1;

        for(int i = 0;i < n;i++)
        {
            if (isSquareNum(arr[i]))
            {
                if (arr[i] < res || res == -1)
                {
                    res = arr[i];
                }     
            }
        }
        return res;
        
    }
}