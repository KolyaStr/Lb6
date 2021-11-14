using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6._3
{
    class Human : IMove
    {
        public int BackSpeed { get; set; }
        public int Speed { get; set; }
        public void Moving()
        {
            Console.WriteLine($"Человек идет назад со скоростью {BackSpeed} км/ч и вперед со скоростью {Speed} км/ч");
        }
    }
}
