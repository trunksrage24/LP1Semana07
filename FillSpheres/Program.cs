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

    /// <summary>
    /// class Color para definir 4 propriedades de cor
    /// </summary>
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        //construtor de Color com as 4 propriedades por definir
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        //construtor de Color com 3 propriedades por definir e alpha definida
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

}