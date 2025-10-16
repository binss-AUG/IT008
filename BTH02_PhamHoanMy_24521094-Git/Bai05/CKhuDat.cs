using System;

namespace Bai05
{
    class CKhuDat
    {
        protected string diadiem { set; get; }
        protected double giaban { set; get; }
        protected double dientich { set; get; }

        public CKhuDat(string diadiem = "", double giaban = 0, double dientich = 0)
        {
            this.diadiem = diadiem;
            this.giaban = giaban;
            this.dientich = dientich;
        }

        protected string isDiaChi(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";
            string[] splitStr = s.Split('-');
            if (splitStr.Length < 4) return "";

            foreach (var p in splitStr)
            {
                if (string.IsNullOrWhiteSpace(p)) return "";
            }
            return s;
        }

        protected void baseNhap()
        {
            do
            {
                Console.WriteLine("Nhập vào địa điểm (format: Số nhà-Tên đường-Phường/Xã-Tỉnh/Thành Phố):");
                diadiem = isDiaChi(Console.ReadLine());
                if (string.IsNullOrEmpty(diadiem))
                {
                    Console.WriteLine("Địa chỉ không hợp lệ. Vui lòng nhập lại.");
                }
            } while (string.IsNullOrEmpty(diadiem));

            bool hopLe;
            do
            {
                Console.Write("Nhập vào giá bán: ");
                try
                {
                    giaban = double.Parse(Console.ReadLine());
                    hopLe = giaban >= 0; 
                    if (!hopLe) Console.WriteLine("Giá bán phải là một số không âm.");
                }
                catch
                {
                    Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập một số.");
                    hopLe = false;
                }
            } while (!hopLe);

            do
            {
                Console.Write("Nhập vào diện tích (m2): ");
                try
                {
                    dientich = double.Parse(Console.ReadLine());
                    hopLe = dientich > 0; 
                    if (!hopLe) Console.WriteLine("Diện tích phải là một số lớn hơn 0.");
                }
                catch
                {
                    Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập một số.");
                    hopLe = false;
                }
            } while (!hopLe);
        }
        public virtual void Nhap()
        {
            Console.WriteLine("\n--------Nhập thông tin Khu Đất--------");
            baseNhap();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("--------Thông tin Khu Đất--------");
            Console.WriteLine($"Địa điểm: {diadiem}");
            Console.WriteLine($"Giá bán: {giaban:N0} VND");
            Console.WriteLine($"Diện tích: {dientich} m2");
        }

        public double getGia() { return giaban; }
        public double getDienTich() { return dientich; }
        public string getDiaDiem() { return diadiem; }
    }
}