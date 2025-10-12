using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HinhTamGiac : Shape
    {
        private double _canh1;
        private double _canh2;
        private double _canh3;

        public double canh1
        {
            get { return _canh1; }
            set { _canh1 = value; }
        }
        public double canh2
        {
            get { return _canh2; }
            set { _canh2 = value; }
        }
        public double canh3
        {
            get { return _canh3; }
            set { _canh3 = value; }
        }
        private bool isCanh(double a, double b, double c)
        {
            return ((a + b > c) && (a + c > b) && (b + c > a));
        }
        public override void Nhap()
        {
            Console.WriteLine("____Nhap vao du lieu hinh tam giac____");
            do {
                do
                {
                    Console.WriteLine("Nhap vao canh 1: ");
                    canh1 = double.Parse(Console.ReadLine());
                    if (canh1 < 0) Console.WriteLine("Gia tri nhap sai, vui long nhap lai!");
                } while (canh1 < 0);

                do
                {
                    Console.WriteLine("Nhap vao canh 2: ");
                    canh2 = double.Parse(Console.ReadLine());
                    if (canh2 < 0) Console.WriteLine("Gia tri nhap sai, vui long nhap lai!");
                } while (canh2 < 0);

                do
                {
                    Console.WriteLine("Nhap vao canh 3: ");
                    canh3 = double.Parse(Console.ReadLine());
                    if (canh3 < 0) Console.WriteLine("Gia tri nhap sai, vui long nhap lai!");
                } while (canh3 < 0);

                if (!isCanh(canh1, canh2, canh3)) Console.WriteLine("Ba canh nhap vao khong phai tam giac, vui long nhap lai!");  
            } while (!isCanh(canh1, canh2, canh3));
        }
        public override void Xuat()
        {
            Console.WriteLine("____Nhap vao du lieu hinh chu nhat____");
            Console.WriteLine("Canh 1 cua hinh tam giac la: " + canh1);
            Console.WriteLine("Canh 1 cua hinh tam giac la: " + canh2);
            Console.WriteLine("Canh 1 cua hinh tam giac la: " + canh3);
            Console.WriteLine("Dien tich cua hinh tam giac la: " + DienTich());
        }
        public override double DienTich()
        {
            double p = (canh1 + canh2 + canh3) / 2;
            return Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }
    }
}
