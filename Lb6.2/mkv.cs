using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6._2
{
    class mkv : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Видео проигрывается.");
        }
        public void Pause()
        {
            Console.WriteLine("Видео на паузе.");
        }
        public void Stop()
        {
            Console.WriteLine("Видео остановлено.");
        }

        string condition;

        public void MakeVideo()
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
