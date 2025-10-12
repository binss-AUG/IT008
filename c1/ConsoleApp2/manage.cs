using ConsoleApp2;
using System;

namespace CosonleApp2
{
    class Manage
    {
        public int soluong;
        public Shape[] arr;

        public Manage()
        {
            soluong = 0;
            arr = new Shape[0];
        }

        public Manage(int n)
        {
            soluong = n;
            arr = new Shape[soluong];
        }

        public void Nhap()
        {
            Console.WriteLine("____Quan Li Shape____");
            if (soluong == 0)
            {
                Console.WriteLine("Nhap vao so luong: ");
                soluong = int.Parse(Console.ReadLine());
                arr = new Shape[soluong];
            }
            Random rand = new Random();
            for (int i = 0; i < soluong; i++)
            {
                int temp = rand.Next(4);

                switch (temp)
                {
                    case 0:
                        Console.WriteLine("Ngau nhien hinh tam giac");
                        arr[i] = new HinhTamGiac();
                        break;
                    case 1:
                        Console.WriteLine("Ngau nhien hinh chu nhat");
                        arr[i] = new HinhChuNhat();
                        break;
                    case 2:
                        Console.WriteLine("Ngau nhien hinh vuong");
                        arr[i] = new HinhVuong();
                        break;
                    case 3:
                        Console.WriteLine("Ngau nhien hinh tron");
                        arr[i] = new HinhTron();
                        break;
                    default:
                        Console.WriteLine("Khong hop le tao hinh mac dinh");
                        arr[i] = new HinhVuong();
                        break;
                }

                arr[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Xuat cac hinh hien tai!");
            for (int i = 0; i < soluong; i++)
            {
                Console.WriteLine("Hinh thu " + i);
                arr[i].Xuat();
            }
        }

        static void Main(string[] agr)
        {
            Manage M1 = new Manage();

            M1.Nhap();
            M1.Xuat();
        }
    }
}