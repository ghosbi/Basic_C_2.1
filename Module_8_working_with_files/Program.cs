using System; // Подключенное пространство имен
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.IO;


namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main()
        {
            // сохраняем путь к файлу (допустим, вы его скачали на рабочий стол)
            string filePath = @"C:\\Users\\Pavel\\Desktop\\BinaryFile.bin";
           // при запуске проверим, что файл существует
            if (File.Exists(filePath))
            {
                // строковая переменная, в которую будем считывать данные
                string stringValue;
                // считываем, после использования высвобождаем задействованный ресурс BinaryReader
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    
                    stringValue = reader.ReadString();
                }

                Console.WriteLine("Из файл считано");
                Console.WriteLine(stringValue);
            }

        }

        
        static void GetCatalogs()
        {
            /*string dirName = @"C:\\";
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


                
            } */
        }

        static void theory()
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

            /*
           


            string tempFile = Path.GetTempFileName();// используем генерацию имени файла.
            var fileInfo = new FileInfo(tempFile);// Создаем объект класса FileInfo.

            //Создаем файл и записываем в него.
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Igor");
                sw.WriteLine("Andrey");
                sw.WriteLine("Sergey");

            }

            //Открываем файл и читаем из него.
            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            try
            {
                string tempFile2 = Path.GetTempFileName();
                var fileInfo2 = new FileInfo(tempFile2);

                // Убедимся, что файл назначения точно отсутствует
                fileInfo2.Delete();

                // Копируем информацию
                fileInfo.CopyTo(tempFile2);
                Console.WriteLine($"{tempFile} coppyTo {tempFile2}.");

                //Удаляем ранее созданный файл.
                fileInfo.Delete();
                Console.WriteLine($"{tempFile}Delete");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Oleg");
                    sw.WriteLine("Dima");
                    sw.WriteLine("Ivan");
                }
            }

            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            var fileInfo = new FileInfo(@"E:\Programm Files\Project Course\Basic 2.0\Basic C# 2.0\Module_8_working_with_files\Program.cs");

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            */

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

// Время запуска: 07.06.2023 21:42:50
