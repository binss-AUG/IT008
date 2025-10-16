using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("==      CHƯƠG TRÌNH XỬ LÝ PHÂN SỐ     ==");
                Console.WriteLine("========================================");
                Console.WriteLine("== 1. Tính toán trên hai phân số      ==");
                Console.WriteLine("== 2. Thao tác trên dãy phân số       ==");
                Console.WriteLine("== 0. Thoát chương trình              ==");
                Console.WriteLine("========================================");
                Console.Write("Mời bạn chọn chức năng: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write($"Lỗi nhập lựa chọn {ex.Message} !!");
                    choice = -1;
                }

                switch (choice)
                {
                    case 1:
                        TinhToanCoBan();
                        break;
                    case 2:
                        ThaoTacVoiDay();
                        break;
                }
                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại Menu...");
                    Console.ReadKey();
                }
            } while (choice != 0);
        }

        static void TinhToanCoBan()
        {
            try // em có kham khảo khi dùng try catch để xử lý ngoại lệ giúp code clean hơn :>>
            {
                Console.WriteLine("\n---Nhập phân số thứ 1---");
                Console.Write("Tử số: "); int tu1 = int.Parse(Console.ReadLine());
                Console.Write("Mẫu số: "); int mau1 = int.Parse(Console.ReadLine());
                CPhanSo p1 = new CPhanSo(tu1, mau1);

                Console.WriteLine("\n---Nhập phân số thứ 2---");
                Console.Write("Tử số: "); int tu2 = int.Parse(Console.ReadLine());
                Console.Write("Mẫu số: "); int mau2 = int.Parse(Console.ReadLine());
                CPhanSo p2 = new CPhanSo(tu2, mau2);

                Console.WriteLine("\n--- KẾT QUẢ ---");
                Console.WriteLine($"{p1} + {p2} = {p1 + p2}");
                Console.WriteLine($"{p1} - {p2} = {p1 - p2}");
                Console.WriteLine($"{p1} * {p2} = {p1 * p2}");
                Console.WriteLine($"{p1} / {p2} = {p1 / p2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        static void ThaoTacVoiDay()
        {
            try
            {
                LCPhanso danhSachPhanSo = new LCPhanso();
                danhSachPhanSo.Nhap();

                CPhanSo max = danhSachPhanSo.TimMax();
                Console.WriteLine($"Phân số lớn nhất là: {max}");

                danhSachPhanSo.SapXepTangDan();
                Console.Write("Dãy sau khi sắp xếp tăng dần: ");
                danhSachPhanSo.Xuat();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}