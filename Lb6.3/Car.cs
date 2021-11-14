using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6._3
{
    class Car : Automobile, IMove
    {
        public double Volume { get; set; }
        public int BackSpeed { get; set; }
        public int Speed { get; set; }
        public Car(string model, string colour, double volume) : base(model, colour)
        {
            Volume = volume;
        }
        public void Moving()
        {
            Console.WriteLine($"Авто едет назад со скоростью {BackSpeed} км/ч и вперед со скоростью {Speed} км/ч");
        }
        public void Print()
        {
            Console.WriteLine($"Марка автомобиля {Model}, цвет {Colour}, объем двигателя {Volume}");
        }
    }
}
