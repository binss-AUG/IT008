using System;

namespace Bai05
{
    class CNhaPho : CKhuDat
    {
        private int namxaydung { set; get; }
        private int sotang { set; get; }

        public CNhaPho() { }

        public override void Nhap()
        {
            Console.WriteLine("\n--------Nhập thông tin Nhà Phố--------");
            base.baseNhap();

            bool hopLe;
            do
            {
                Console.Write("Nhập vào năm xây dựng: ");
                try
                {
                    namxaydung = int.Parse(Console.ReadLine());
                    hopLe = namxaydung <= DateTime.Now.Year;
                    if (!hopLe) Console.WriteLine($"Năm xây dựng phải là một số hợp lệ (lớn hơn 1800 và nhỏ hơn hoặc bằng {DateTime.Now.Year}).");
                }
                catch
                {
                    Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập một số nguyên.");
                    hopLe = false;
                }
            } while (!hopLe);

            do
            {
                Console.Write("Nhập vào số tầng: ");
                try
                {
                    sotang = int.Parse(Console.ReadLine());
                    hopLe = sotang > 0;
                    if (!hopLe) Console.WriteLine("Số tầng phải là một số nguyên lớn hơn 0.");
                }
                catch
                {
                    Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập một số nguyên.");
                    hopLe = false;
                }
            } while (!hopLe);
        }

        public override void Xuat()
        {
            Console.WriteLine("--------Thông tin Nhà Phố---------");
            Console.WriteLine($"Địa điểm: {diadiem}");
            Console.WriteLine($"Giá bán: {giaban:N0} VND");
            Console.WriteLine($"Diện tích: {dientich} m2");
            Console.WriteLine($"Năm xây dựng: {namxaydung}");
            Console.WriteLine($"Số tầng: {sotang}");
        }

        public int getNamXayDung() { return namxaydung; }
    }
}