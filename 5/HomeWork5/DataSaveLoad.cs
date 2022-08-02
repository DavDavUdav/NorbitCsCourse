using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HomeWork5
{
    class DataSaveLoad
    {
        /// <summary>
        /// Запись данных в файл.
        /// </summary>
        public static async void Write(string str)
        {
            var person = new Person("Stepan", 22);
            string saveInfo = JsonSerializer.Serialize<Person>(person);
            File.WriteAllText(str, saveInfo);

            Console.WriteLine("Запись в файл завершена");
        }

        /// <summary>
        /// Чтение данных из файла.
        /// </summary>
        public static void Read(string str)
        {
            var infoFile = File.ReadAllText(str);
            Person person = JsonSerializer.Deserialize<Person>(infoFile);

            Console.WriteLine(person?.Name + ", " + person?.Age);
            Console.WriteLine("Чтение с файла завершено");
        }
    }
}
