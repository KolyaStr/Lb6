using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6._2
{
    class wav : IPlayable, IRecordable
    {
        public void Pause()
        {
            Console.WriteLine("wav на паузе.");
        }
        public void Stop()
        {
            Console.WriteLine("wav остановлена.");
        }
        public void Play()
        {
            Console.WriteLine("wav играет.");

        }
        public void Record()
        {
            Console.WriteLine("wav записывается.");
        }
        string condition;

        public void MakeMusic()
        {
            do
            {
                string variant = Console.ReadLine();
                condition = variant;
                switch (variant)
                {
                    case "play":
                        Play();
                        break;
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
                        break;

                }
            } while (condition != "exit");

        }
    }
}
