using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lb6._1
{
    class TXTHandler : AbstractHandler
    {
        public void Create()
        {
            using (FileStream fstream = new FileStream($"D:\\{name}.txt", FileMode.OpenOrCreate))
            {
            }

        }
        public void Open()
        {
            using (FileStream fstream = File.OpenRead($"D:\\{name}.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

        }
        public void Change()
        {
            Console.WriteLine("Введите текст, который нужно дописать вконец файла: ");
            string text = Console.ReadLine();
            using (FileStream fstream = new FileStream($"D:\\{name}.txt", FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);

            }
        }
    }
}
