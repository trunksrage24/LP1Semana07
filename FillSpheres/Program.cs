using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Color
    {
        byte red
        byte green
        byte blue
        byte alpha
        
        //colorize 4 paramenters
        public byte Color (byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        //colorize 3 parameters
        public byte Color (byte red, byte green, byte blue, byte alpha)
        {
            byte alpha = 255;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
    }

    class Sphere
    {
       int color;
       int radius;
       int thrown;

    }

}
