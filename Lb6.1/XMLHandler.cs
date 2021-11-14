using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lb6._1
{
    class XMLHandler : AbstractHandler
    {
        public void Create()
        {
            using (FileStream fstream = new FileStream($"D:\\{name}.xml", FileMode.OpenOrCreate))
            {
            }

        }
        public void Open()
        {
            using (FileStream fstream = File.OpenRead($"D:\\{name}.xml"))
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
            using (FileStream fstream = new FileStream($"D:\\{name}.xml", FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);

            }
        }
    }
}
