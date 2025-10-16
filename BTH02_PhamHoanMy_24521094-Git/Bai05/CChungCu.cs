using System;

namespace Bai05
{
    class CChungCu : CKhuDat
    {
        private int tang { set; get; }

        public CChungCu() { }

        public override void Nhap()
        {
            Console.WriteLine("\n--------Nhập thông tin Chung Cư--------");
            base.baseNhap();

            bool hopLe;
            do
            {
                Console.Write("Nhập vào tầng: ");
                try
                {
                    tang = int.Parse(Console.ReadLine());
                    hopLe = tang > 0;
                    if (!hopLe) Console.WriteLine("Tầng phải là một số nguyên lớn hơn 0.");
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
            Console.WriteLine("--------Thông tin Chung Cư------");
            Console.WriteLine($"Địa điểm: {diadiem}");
            Console.WriteLine($"Giá bán: {giaban:N0} VND");
            Console.WriteLine($"Diện tích: {dientich} m2");
            Console.WriteLine($"Tầng: {tang}");
        }
    }
}