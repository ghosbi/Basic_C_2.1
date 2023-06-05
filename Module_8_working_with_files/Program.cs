using System; // Подключенное пространство имен
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args)
        {

            /* получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}"); 
                }
            } */

            GetCatalogs();

        }

        static void GetCatalogs()
        {
            string dirName = @"C:\\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки");
                string[] dirs = Directory.GetDirectories(dirName);

                foreach (string d in dirs)
                {
                    Console.WriteLine(d);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\Pavel\\Desktop\\testFolder");
                    FileSystem.DeleteDirectory(dirInfo.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                
            }
        }
    }

}


public class Drive
{
    public Drive(string name, long totalSpace, long freeSpace)
    {
        Name = name;
        TotalSpace = totalSpace;
        freeSpace = freeSpace;
    }

    public string Name { get; }
    public long TotalSpace { get; }
    public long FreeSpace { get; }

}

public class Folder
{
    public List<string> Files { get; set; } = new List<string>();

    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    public void CreateFolder(string name)
    {
        Folders.Add(name, new Folder());
    }
}