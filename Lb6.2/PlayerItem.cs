using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lb6._2
{
    class PlayerItem : IMedia
    {
        public string dirName { set; get; }

        public void Type()
        {
            PlayerItem playerItem = new PlayerItem();
            playerItem.dirName = @"C:\Users\Kolya\source\repos\Lb6.1\Lb6.2\media\";
            string[] files = Directory.GetFiles(playerItem.dirName);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
        }
        
    }
}
