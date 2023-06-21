﻿using System; // Подключенное пространство имен
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.Design.Serialization;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {

        static void Main(string[] args)
        {
            Mail newMail = new Mail();

            ((IWriter)newMail).Writer("Хеллоу всем");

            Console.ReadKey();

        }
        
    }

    public class Mail:IWriter
    {
        void IWriter.Writer(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface IWriter
    {
        void Writer(string message);
    }

    public interface IManager
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }

    public class Manager : IManager
    {
        public void Create()
        {

        }

        public void Delete()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }
    }
}