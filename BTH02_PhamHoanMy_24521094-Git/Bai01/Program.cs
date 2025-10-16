using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CDate myDate = new CDate();
            do
            {
                try
                {
                    Console.Write("Nhập vào tháng: ");
                    myDate.mm = int.Parse(Console.ReadLine());
                }
                catch
                {
                    myDate.mm = 13;
                }

                if (myDate.mm < 1 || myDate.mm > 12)
                {
                    Console.WriteLine("Tháng vừa nhập không hợp lệ!");
                }
            } while ((myDate.mm < 1 || myDate.mm > 12));

            do
            {
                try
                {
                    Console.Write("Nhập vào năm: ");
                    myDate.yy = int.Parse(Console.ReadLine());
                }
                catch
                {
                    myDate.yy = 0;
                }

                if (myDate.yy < 1)
                {
                    Console.WriteLine("Năm vừa nhập không hợp lệ!");
                }
            } while ((myDate.yy < 1));

            const int pad = 5;

            string[] textWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for (int i = 0; i < textWeek.Length; i++) Console.Write($"{textWeek[i],pad}");
            Console.WriteLine();
            int DofM = myDate.thMonth();
            int DofW = myDate.thWeek();
            for(int i = 1;i <= DofW;i++)
            {
                Console.Write($"{" ",pad}");
            }
            for(int i = 1;i <= DofM;i++)
            {
                if (DofW >= 7)
                {
                    DofW = 0;
                    Console.WriteLine();
                }
                Console.Write($"{i,pad}");
                DofW++;
                
            }
        }
    }
}
