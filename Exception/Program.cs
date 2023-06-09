using System; // Подключенное пространство имен
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Собственное исключение");

            exception.Data.Add("Дата создания:", DateTime.Now);



            exception.HelpLink = "www.yandex.ru";
        }
    }
}