using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;

namespace Bai06;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập vào kích thước dòng của mảng: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhập vào kích thước cột của mảng: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhập vào số thứ tự k là dòng cần xóa : ");
        int k = int.Parse(Console.ReadLine());

        int[,] arr = new int[n,m];

        InputArr(arr, n, m);

        PrintList(arr, n, m, k);

    }
    static void PrintList(int[,] arr, int n, int m, int k)
    {
        if (isEmpty(n, m))
        {
            Console.WriteLine("Ma trận rỗng!");
            return;
        }
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("1: Xuất ma trận: ");
        PrintArr(arr, n, m);

        Console.WriteLine("2: Giá trị lớn nhất/nhỏ nhất trong ma trận: " + MaxArr(arr, n, m) + "/" + MinArr(arr, n, m));

        Console.Write("3: Dòng có tổng giá trị lớn nhất là: ");
        MaxRow(arr, n, m);

        Console.WriteLine("4: Tổng các giá trị không phải số nguyên tố: " + notPrimeSum(arr, n, m));

        Console.WriteLine("5: Xóa dòng thứ k trong ma trận: ");
        DelRowK(arr, n, m, k);

        Console.WriteLine("6: Xóa cột đang giữ giá trị lớn nhất: ");
        DelMaxCol(arr, n, m);

        Console.WriteLine("-------------------------------------------------------------");
    }
    static void PrintArr(int[,] arr, int n, int m)
    {
        if (isEmpty(n,m))
        {
            Console.WriteLine("Ma trận rỗng!");
            return;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
    static void InputArr(int[,] arr, int n, int m)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0;j < m;j++)
            {
                arr[i,j] = rand.Next(-100, 100);
            }
        }

    }
    static bool isEmpty(int n, int m)
    {
        return (m == 0 || n == 0);
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
    static int MaxArr(int[,] arr, int n, int m)
    {
        int max = int.MinValue;

        for(int i = 0;i < n;i++)
        {
            for(int j = 0;j < m;j++)
            {
                max = Math.Max(max, arr[i,j]); 
            }    
        }

        return max;
    }
    static int MinArr(int[,] arr, int n, int m)
    {
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                min = Math.Min(min, arr[i,j]);
            }
        }

        return min;
    }
    static int SumRow(int[,] arr, int n, int m)
    {
        int res = 0;
        for (int j = 0; j < m; j++) res += arr[n, j]; 
        return res;
    }
    static void MaxRow(int[,] arr, int n, int m)
    {
        int maxsum = 0;
        int[] tempsum = new int[n]; 
        for (int i = 0; i < n; i++)
        {
            tempsum[i] = SumRow(arr, i, m);
            
            if (i == 0)
            {
                maxsum = tempsum[i];
                continue;
            }
            if (tempsum[i] > maxsum)
            {
                maxsum = tempsum[i];
            }
        }

        for(int i = 0;i < n;i++)
        {
            if (tempsum[i] == maxsum)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        return;

    }
    static int notPrimeSum(int[,] arr, int n, int m)
    {
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if ( !isPrime(arr[i, j]) ) sum += arr[i,j];
            }
        }

        return sum;
    }
    static void DelRowK(int[,] arr, int n, int m, int k)
    {
        if (n <= 0)
        {
            Console.WriteLine("Không xóa được, đã đạt kích thước tôi thiểu!");
            return;
        }
        if (k < 0 || n <= k)
        {
            Console.WriteLine("Không xóa được, giá trị k nằm ngoài ma trận!");
            return;
        }
        int[,] res = new int[n-1, m];
        int ires = 0;
        for(int i = 0;i < n;i++)
        {
            int jres = 0;
            if (i == k) continue;
            for(int j = 0;j < m;j++)
            {
                res[ires, jres++] = arr[i, j];
            }
            ires++;
        }
        PrintArr(res, n - 1, m);
    }
    static int[,] DelColK(int[,] arr, int n, int m, int k)
    {
        if (m <= 0)
        {
            Console.WriteLine("Không xóa được, đã đạt kích thước tôi thiểu!");
            return arr;
        }

        if (k < 0 || m <= k)
        {
            Console.WriteLine("Không xóa được, giá trị k nằm ngoài ma trận!");
            return arr;
        }
        int[,] res = new int[n, m-1];
        int jres = 0;
        for (int j = 0; j < m; j++)
        {
            int ires = 0;
            if (j == k) continue;
            for (int i = 0; i < n; i++)
            {
                res[ires++, jres] = arr[i, j];
            }
            jres++;
        }

        return res;

    }
    static void DelMaxCol(int[,] arr, int n, int m)
    {
        int[] maxcolArr = new int[n];
        int maxcolCount = 0;
        int curCount = 0;
        int[,] curarr = arr;
        int maxarr = MaxArr(curarr, n, m);
        for(int j = 0;j < m;j++)
        {
            for(int i = 0;i < n;i++)
            {
                if (curarr[i, j] == maxarr)
                {
                    maxcolArr[maxcolCount] = j;
                    maxcolCount++;
                    break;
                }
            }
        }

        for(int i = 0;i < maxcolCount;i++)
        {
            curarr = DelColK(curarr, n, m, maxcolArr[i] - curCount);
            m--;
            curCount++;
        }
        PrintArr(curarr, n, m);
        return ;
    }
}