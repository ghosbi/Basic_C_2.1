using System; // Подключенное пространство имен
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args)
        {
            
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