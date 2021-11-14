using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Lb6._2
{
        class Program
        {
            static void Main(string[] args)
            {
                PlayerItem playerItem = new PlayerItem();
                playerItem.Type();

                Console.WriteLine("Выберите формат: mkv, mp3, wav или exit для выхода.");
                string condition;
                mkv mkv = new mkv();
                mp3 mp3 = new mp3();
                wav wav = new wav();
                do
                {
                    string variant = Console.ReadLine();
                    condition = variant;
                    switch (variant)
                    {
                        case "mkv":
                            {
                                Console.WriteLine("Выберите действие : play, record, pause, stop или exit для выхода.");
                                mkv.MakeVideo();
                            }
                            break;
                        case "mp3":
                            {
                                Console.WriteLine("Выберите действие : record, pause, stop или exit для выхода.");
                                mp3.MakeMusic();
                            }

                            break;
                        case "wav":
                            {
                                Console.WriteLine("Выберите действие : play, pause, stop или exit для выхода.");
                                wav.MakeMusic();
                            }
                            break;
                        default:
                            break;

                    }
                } while (condition != "exit");
            }
        }
    
}


