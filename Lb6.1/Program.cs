using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lb6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int num = 0;
            while (a == 0)
            {
                Console.WriteLine("Виберите, с каким типом файла вы хотите работать(написать цифру): ");
                Console.WriteLine("1. txt");
                Console.WriteLine("2. doc");
                Console.WriteLine("3. xml");
                string format = Console.ReadLine();
                if (format.Any(q => char.IsLetter(q)) || string.IsNullOrWhiteSpace(format))
                {
                    Console.WriteLine("Ошибка, вы ввели не число!");
                    continue;
                }
                else
                {
                    num = int.Parse(format);
                    a++;
                }
            }
            if (num == 1)
            {
                TXTHandler txtHandler = new TXTHandler();
                Console.WriteLine("Введите название файла, с которым хотите работать(если это новый файл, введите его название; файл должен храниться на диске D): ");
                txtHandler.name = Console.ReadLine();
                txtHandler.Create();
                txtHandler.Change();
                txtHandler.Open();
            }
            else if (num == 2)
            {
                DOCHandler docHandler = new DOCHandler();
                Console.WriteLine("Введите название файла, с которым хотите работать(если это новый файл, введите его название; файл должен храниться на диске D): ");
                docHandler.name = Console.ReadLine();
                docHandler.Create();
                docHandler.Change();
                docHandler.Open();
            }
            else if (num == 3)
            {
                XMLHandler xmlHandler = new XMLHandler();
                Console.WriteLine("Введите название файла, с которым хотите работать(если это новый файл, введите его название; файл должен храниться на диске D): ");
                xmlHandler.name = Console.ReadLine();
                xmlHandler.Create();
                xmlHandler.Change();
                xmlHandler.Open();
            }
            else
                Console.WriteLine("Такого типа файла нету в списке!");
           
        }
    }
}
