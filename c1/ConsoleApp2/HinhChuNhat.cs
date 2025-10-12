using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HinhChuNhat : Shape
    {
        private double _chieucao;
        private double _chieurong;

        public double chieucao
        {
            get { return _chieucao; }
            set { _chieucao = value; }
        }
        public double chieurong
        {
            get { return _chieurong; }
            set { _chieurong = value; }
        }
        public override void Nhap()
        {
            Console.WriteLine("____Nhap vao du lieu hinh chu nhat____");
            do
            {
                Console.WriteLine("Nhap vao chieu cao hinh chu nhat: ");
                chieucao = double.Parse(Console.ReadLine());
                if (chieucao < 0) Console.WriteLine("Gia tri nhap sai, vui long nhap lai!");
            } while (chieucao < 0);

            do
            {
                Console.WriteLine("Nhap vao chieu rong hinh chu nhat: ");
                chieurong = double.Parse(Console.ReadLine());
                if (chieurong < 0) Console.WriteLine("Gia tri nhap sai, vui long nhap lai!");
            } while (chieurong < 0);
        }
        public override void Xuat()
        {
            Console.WriteLine("____Nhap vao du lieu hinh chu nhat____");
            Console.WriteLine("Chieu cao cua hinh chu nhat la: " + chieucao);
            Console.WriteLine("Chieu rong cua hinh chu nhat la: " + chieurong);
            Console.WriteLine("Dien tich cua hinh chu nhat la: " + DienTich());
        }
        public override double DienTich()
        {
            return chieucao * chieurong;
        }
    }
}
