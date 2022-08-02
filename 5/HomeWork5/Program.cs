using System;
using System.IO;
using System.Text.Json;
using System.Configuration;



namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ConfigurationManager.AppSettings["saveDataFolder"];
            Console.WriteLine(str);
            DataSaveLoad.Write(str);
            DataSaveLoad.Read(str);


        }
    }
}
