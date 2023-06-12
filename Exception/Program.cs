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
        
        public delegate int MinusDelegate(int a, int b);
        delegate void ShowMessageDelegate(string _message);
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = delegate ()
            {
                return new Random().Next(0, 100);
            };
            int result4 = randomNumberDelegate.Invoke();
            Console.WriteLine(result4);

        }

        static void Task9_3_12()
        {
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World");
            Console.Read();


        }
        static bool CheckLength(string _row)
        {
            if (_row.Length > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static void ShowMessage()
        {
            Console.WriteLine("Hello World");
        }
        static int Minus(int a, int b)
        {
            return b - a;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Theory()
        {
            /*
            Exception exception = new Exception("Собственное исключение");

            exception.Data.Add("Дата создания:", DateTime.Now);

            exception.HelpLink = "www.yandex.ru";

            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                throw new RankException();
            }
            catch (RankException ex)
            {

                Console.WriteLine(ex.GetType());
            } */

            MinusDelegate minusDelegate = Minus;
            minusDelegate += Sum;

            minusDelegate -= Sum;
            int result = minusDelegate.Invoke(3, 5);
            int result1 = minusDelegate(6, 3);
            int result2 = minusDelegate(5, 5);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Action showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            Func<int, int, int, int> sumDelegate = Sum;
            int result3 = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result3);

            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("Skill_Factory");
            Console.WriteLine(status);
        }
    }
}