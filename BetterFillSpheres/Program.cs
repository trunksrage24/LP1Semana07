using System;

namespace BetterFillSpheres
{
    /// <summary>
    /// class Program para criar esferas usando dimensao e cor, e rebentar esferas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    /// <summary>
    /// class Color para definir 4 propriedades de cor
    /// </summary>
    public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        //construtor de Color com as 4 propriedades por definir
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        //construtor de Color com 3 propriedades por definir e alpha definida
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
    }
}
