using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai05
{
    class CQuanLi
    {
        private List<CKhuDat> ds = new List<CKhuDat>();

        public void Nhap()
        {
            int soluong = 0;
            bool hopLe;
            do
            {
                Console.Clear();
                Console.WriteLine("--------Nhập vào thông tin của danh sách--------");
                Console.Write("Nhập vào số lượng cần quản lí: ");
                try
                {
                    soluong = int.Parse(Console.ReadLine());
                    hopLe = soluong > 0;
                    if (!hopLe) Console.WriteLine("Số lượng phải lớn hơn 0.");
                }
                catch
                {
                    Console.WriteLine("Giá trị không hợp lệ!");
                    hopLe = false;
                }
            } while (!hopLe);

            for (int i = 0; i < soluong; i++)
            {
                int loai = 0;
                do
                {
                    Console.WriteLine("Chọn loại: 1: Khu đất | 2: Nhà Phố | 3: Chung cư");
                    Console.Write("Lựa chọn của bạn: ");
                    try
                    {
                        loai = int.Parse(Console.ReadLine());
                        hopLe = loai >= 1 && loai <= 3;
                    }
                    catch 
                    { 
                        hopLe = false; 
                    }

                    if (!hopLe) Console.WriteLine("Lựa chọn không hợp lệ!");

                } while (!hopLe);

                CKhuDat temp = null;
                switch (loai)
                {
                    case 1: 
                        temp = new CKhuDat(); 
                        break;
                    case 2: 
                        temp = new CNhaPho(); 
                        break;
                    case 3: 
                        temp = new CChungCu(); 
                        break;
                }

                temp.Nhap(); 
                ds.Add(temp);
            }
        }

        public void Xuat()
        {
            Console.WriteLine("\n--------Xuất ra thông tin của danh sách--------");
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }
            foreach (var i in ds)
            {
                i.Xuat();
                Console.WriteLine();
            }
        }

        public void Tong3()
        {
            double giaKhuDat = 0;
            double giaNhaPho = 0;
            double giaChungCu = 0;

            foreach (var obj in ds)
            {
                if (obj.GetType() == typeof(CKhuDat)) giaKhuDat += obj.getGia();
                else if (obj is CNhaPho) giaNhaPho += obj.getGia();
                else if (obj is CChungCu) giaChungCu += obj.getGia();
            }
            Console.WriteLine("\n--------Xuất ra tổng giá bán 3 loại--------");
            Console.WriteLine($"Tổng giá bán Khu đất: {giaKhuDat:N0} VND");
            Console.WriteLine($"Tổng giá bán Nhà phố: {giaNhaPho:N0} VND");
            Console.WriteLine($"Tổng giá bán Chung cư: {giaChungCu:N0} VND");
        }

        private bool isTask4(CKhuDat obj)
        {
            if (obj.GetType() == typeof(CKhuDat) && obj.getDienTich() > 100) return true;
            if (obj is CNhaPho np && obj.getDienTich() > 60 && np.getNamXayDung() >= 2019) return true;
            return false;
        }

        public List<CKhuDat> Xuat4()
        {
            List<CKhuDat> res = new List<CKhuDat>();
            foreach (var obj in ds)
            {
                if (isTask4(obj)) res.Add(obj);
            }
            return res;
        }

        public List<CKhuDat> Xuat5(string diaDiemSearch, double giaSearch, double dienTichSearch)
        {
            List<CKhuDat> res = new List<CKhuDat>();
            foreach (var obj in ds)
            {
                if (obj is CNhaPho || obj is CChungCu)
                {
                    if (obj.getDiaDiem().ToLower().Contains(diaDiemSearch.ToLower()) &&
                        obj.getGia() <= giaSearch &&
                        obj.getDienTich() >= dienTichSearch)
                    {
                        res.Add(obj);
                    }
                }
            }
            return res;
        }
    }
}