using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Nhập đường dẫn thư mục: ");
            string path = Console.ReadLine();

            //string path = "D:/Meox/tool";
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Lỗi: Đường dẫn không tồn tại.");
                return;
            }

            Console.WriteLine($"\n Directory of {path}\n");

            long totalFileSize = 0;
            int directoryCount = 0;
            int fileCount = 0;

            string[] directories = Directory.GetDirectories(path);
            foreach (string dirPath in directories)
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                // chổ này em canh tay luôn :>>> 
                Console.WriteLine($"{dir.LastWriteTime:dd/MM/yyyy hh:mm tt} {string.Empty,1} <DIR> {string.Empty,18} {dir.Name}");
                directoryCount++;
            }

            string[] files = Directory.GetFiles(path);
            foreach (string filePath in files)
            {
                FileInfo file = new FileInfo(filePath);
                Console.WriteLine($"{file.LastWriteTime:dd/MM/yyyy hh:mm tt} {file.Length,26:N0} {file.Name}");
                fileCount++;
                totalFileSize += file.Length;
            }

            Console.WriteLine($"\n{fileCount,22} File(s) {totalFileSize,15:N0} bytes");
            Console.WriteLine($"{directoryCount,22} Dir(s)");

            try
            {
                DriveInfo drive = new DriveInfo(Path.GetPathRoot(path));
                Console.WriteLine($"{string.Empty,31} {drive.AvailableFreeSpace:N0} bytes free");
            }
            catch
            {
            }
        }
    }
}