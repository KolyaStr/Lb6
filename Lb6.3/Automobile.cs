using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6._3
{
    abstract class Automobile
    {
        public string Model { get; set; }
        public string Colour { get; set; }
        public Automobile(string model, string colour)
        {
            Model = model;
            Colour = colour;
        }

    }
}
