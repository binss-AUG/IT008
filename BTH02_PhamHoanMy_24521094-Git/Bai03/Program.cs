using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            CMatrix matrix = null;
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("============================================");
                Console.WriteLine("==                Ma trận                 ==");
                Console.WriteLine("============================================");
                Console.WriteLine("== 1. Nhập và xuất ma trận                ==");
                Console.WriteLine("== 2. Tìm kiếm 1 phần tử                  ==");
                Console.WriteLine("== 3. Xuất các số nguyên tố               ==");
                Console.WriteLine("== 4. Tìm dòng có nhiều số nguyên tố nhất ==");
                Console.WriteLine("== 0. Thoát chương trình                  ==");
                Console.WriteLine("============================================");
                Console.Write("Mời bạn lựa món:>>: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    choice = -1;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập số dòng: ");
                        int rows = isInt(Console.ReadLine());
                        Console.Write("Nhap số cột: ");
                        int cols = isInt(Console.ReadLine());
                        if (rows < 0 || cols < 0)
                        {
                            Console.WriteLine("Giá trị vừa nhập không phù hợp!");
                            break;
                        }
                        matrix = new CMatrix(rows, cols);
                        matrix.Input();
                        matrix.Ouput();
                        break;
                    case 2:
                        if (matrix == null)
                        {
                            Console.WriteLine("Lỗi: Nhập ma trận đã!!");
                        }
                        else
                        {
                            Console.Write("Nhập vào giá trị cần tìm: ");
                            int valueToFind = int.Parse(Console.ReadLine());
                            matrix.TimKiem(valueToFind);
                        }
                        break;
                    case 3:
                        if (matrix == null)
                        {
                            Console.WriteLine("Lỗi: Nhập ma trận đã!!");
                        }
                        else
                        {
                            matrix.countPrime();
                        }
                        break;
                    case 4:
                        if (matrix == null)
                        {
                            Console.WriteLine("Lỗi: Nhập ma trận đã!!");
                        }
                        else
                        {
                            matrix.mostPrimeinLine();
                        }
                        break;
                    case 0:
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Bạn đã nhập sai. Vui lòng nhập lại!");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kì để trờ về");
                    Console.ReadKey();
                }

            } while (choice != 0);
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
    }
}