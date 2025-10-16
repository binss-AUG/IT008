using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            CQuanLi ql = null;
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("================================================================");
                Console.WriteLine("=********************Công ty địa ốc Đại Phú********************=");
                Console.WriteLine("= 1. Nhập danh sách                                            =");
                Console.WriteLine("= 2. Xuất danh sách                                            =");
                Console.WriteLine("= 3. Xuất tổng giá bán 3 loại                                  =");
                Console.WriteLine("= 4. Xuất khu đất (>100m2) hoặc nhà phố (>60m2, từ 2019)       =");
                Console.WriteLine("= 5. Tìm kiếm nhà phố hoặc chung cư theo yêu cầu               =");
                Console.WriteLine("= 0. Thoát                                                     =");
                Console.WriteLine("================================================================");
                Console.Write("Vui lòng nhập lựa chọn: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    choice = -1;
                }

                switch (choice)
                {
                    case 1:
                        ql = new CQuanLi();
                        ql.Nhap();
                        break;
                    case 2:
                        if (ql == null)
                        {
                            Console.WriteLine("Chưa có dữ liệu!");
                            break;
                        }
                        ql.Xuat();
                        break;
                    case 3:
                        if (ql == null)
                        {
                            Console.WriteLine("Chưa có dữ liệu!");
                            break;
                        }
                        ql.Tong3();
                        break;
                    case 4:
                        if (ql == null)
                        {
                            Console.WriteLine("Chưa có dữ liệu!");
                            break;
                        }
                        List<CKhuDat> res4 = ql.Xuat4();
                        Console.WriteLine("\n--------Xuất danh sách đạt điều kiện--------");
                        if (res4.Count == 0)
                        {
                            Console.WriteLine("Không có đối tượng nào thỏa mãn điều kiện.");
                        }
                        else
                        {
                            foreach (CKhuDat obj in res4)
                            {
                                obj.Xuat();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 5:
                        if (ql == null)
                        {
                            Console.WriteLine("Chưa có dữ liệu!");
                            break;
                        }
                        try
                        {
                            Console.WriteLine("\nNhập thông tin cần tìm kiếm cho Nhà Phố hoặc Chung Cư:");
                            Console.Write("Nhập chuỗi địa điểm cần tìm: ");
                            string diaDiemTim = Console.ReadLine();
                            Console.Write("Nhập mức giá tối đa: ");
                            double giaTim = double.Parse(Console.ReadLine());
                            Console.Write("Nhập diện tích tối thiểu: ");
                            double dienTichTim = double.Parse(Console.ReadLine());

                            List<CKhuDat> res5 = ql.Xuat5(diaDiemTim, giaTim, dienTichTim);
                            Console.WriteLine("\n--------Danh sách kết quả tìm kiếm--------");
                            if (res5.Count == 0)
                            {
                                Console.WriteLine("Không tìm thấy kết quả phù hợp.");
                            }
                            else
                            {
                                foreach (CKhuDat obj in res5)
                                {
                                    obj.Xuat();
                                    Console.WriteLine();
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Giá hoặc diện tích nhập vào không hợp lệ!");
                        }

                        break;
                    case 0:
                        Console.WriteLine("Đang thoát chương trình..");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím Enter để trở về menu chính...");
                    Console.ReadLine();
                }

            } while (choice != 0);

        }
    }
}