using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HinhVuong : Shape
    {
        private double _canh;

        public double canh
        {
            get { return _canh; }
            set { _canh = value; }
        }
        public override void Nhap()
        {
            Console.WriteLine("____Nhap vao du lieu hinh vuong____");
            do
            {
                Console.WriteLine("Nhap vao canh hinh vuong: ");
                canh = double.Parse(Console.ReadLine());
                if (canh < 0) Console.WriteLine("Gia tri nhap sai, vui long nhap lai!");
            } while (canh < 0);
        }
        public override void Xuat()
        {
            Console.WriteLine("____Xuat ra du lieu hinh vuong____");
            Console.WriteLine("Canh cua hinh vuong la: " + canh);
            Console.WriteLine("Dien tich cua hinh vuong la: " + DienTich());
        }
        public override double DienTich()
        {
            return canh * canh;
        }
    }
}
