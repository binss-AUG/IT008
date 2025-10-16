using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class CMatrix
    {
        private int[,] data;
        private int rows;
        private int cols;

        public CMatrix(int numRows = 0, int numCols = 0)
        {
            rows = numRows;
            cols = numCols;
            data = new int[rows, cols];
        }

        public void Input()
        {
            Console.WriteLine("\n---Nhập vào ma trận---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhập phần tử [{i},{j}]: ");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("----------------------");
        }

        public void Ouput()
        {
            Console.WriteLine("\n---Xuất ra ma trận---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{data[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        public void TimKiem(int giaTriCanTim)
        {
            bool found = false;
            Console.WriteLine($"\n---Kết quả tìm kiếm của giá trị '{giaTriCanTim}'---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i, j] == giaTriCanTim)
                    {
                        Console.WriteLine($"Tìm thấy '{giaTriCanTim}' tại vị trí: [{i}, {j}]");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"Không tìm thấy giá trị '{giaTriCanTim}' trong ma trận.");
            }
        }

        public void countPrime()
        {
            Console.Write("\n---Các số nguyên tố trong ma trận---\n");
            bool found = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (isPrime(data[i, j]))
                    {
                        Console.Write($"{data[i, j]}  ");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.Write("Không có số ngyên tố trong ma trận.");
            }
            Console.WriteLine();
        }

        public void mostPrimeinLine()
        {
            int maxCount = -1;
            int[] res = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int currentPrimeCount = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (isPrime(data[i, j]))
                    {
                        currentPrimeCount++;
                    }
                }
                res[i] = currentPrimeCount;
                if (currentPrimeCount > maxCount)
                {
                    maxCount = currentPrimeCount;
                }
            }

            Console.WriteLine("\n---Dòng có nhiều số nguyên tố nhất---");
            if (maxCount > 0)
            {
                for(int i = 0;i < rows;i++)
                {
                    if (res[i] == maxCount)
                    {
                        Console.WriteLine($"Dòng {i} có nhiều số nguyên tố nhất với {maxCount} số.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ma trận không có số nguyên tố nào.");
            }
        }

        private bool isPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
