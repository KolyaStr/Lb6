using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6._3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("KIA", "Red", 1.5);
            car1.BackSpeed = -35;
            car1.Speed = 180;
            car1.Print();
            car1.Moving();
            Console.WriteLine();


            Car car2 = new Car("Toyota", "Black", 2.1);
            car2.BackSpeed = -48;
            car2.Speed = 240;
            car2.Print();
            car2.Moving();
            Console.WriteLine();

            Human human = new Human();
            human.BackSpeed = -2;
            human.Speed = 4;
            human.Moving();
            Console.WriteLine();
        }
    }
}
