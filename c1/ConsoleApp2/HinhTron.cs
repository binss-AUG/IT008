using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HinhTron : Shape
    {
        private double _bankinh;

        public double bankinh
        {
            get { return _bankinh; }
            set { _bankinh = value; }
        }
        public override void Nhap()
        {
            Console.WriteLine("____Nhap vao du lieu hinh tron____");
            do
            {
                Console.WriteLine("Nhap vao ban kinh hinh tron: ");
                bankinh = double.Parse(Console.ReadLine());
                if (bankinh < 0) Console.WriteLine("Gia tri nhap sai, vui long nhap lai!");
            } while (bankinh < 0);
        }
        public override void Xuat()
        {
            Console.WriteLine("____Xuat ra du lieu hinh tron____");
            Console.WriteLine("Ban kinh cua hinh tron la: " + bankinh);
            Console.WriteLine("Dien tich cua hinh tron la: " + DienTich());
        }
        public override double DienTich()
        {
            return Math.PI * Math.PI * bankinh;
        }
    }
}
