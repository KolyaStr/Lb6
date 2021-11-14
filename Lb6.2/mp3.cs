using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6._2
{
    class mp3 : IRecordable
    {
        string condition;

        public void Pause()
        {
            Console.WriteLine("mp3 на паузе.");
        }
        public void Stop()
        {
            Console.WriteLine("mp3 остановлено.");
        }
        public void Record()
        {
            Console.WriteLine("mp3 записывается.");
        }
        public void MakeMusic()
        {
            do
            {
                string variant = Console.ReadLine();
                condition = variant;
                switch (variant)
                {
                    case "record":
                        Record();
                        break;
                    case "pause":
                        Pause();
                        break;
                    case "stop":
                        Stop();
                        break;
                    default:
                        {
                            Console.WriteLine("Данное действие недоступно для выбраного формата!");
                        }
                        break;

                }
            } while (condition != "exit");

        }
    }
}
