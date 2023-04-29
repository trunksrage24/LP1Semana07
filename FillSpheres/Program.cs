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

        //getter e setter para red
        public int Red
        {
            get { return red; }
            set { red = value; }
        }

        //getter e setter para green
        public int Green
        {
            get { return green; }
            set { green = value; }
        }

        //getter e setter para blue
        public int Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        //getter e setter para alpha
        public int Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        /// <summary>
        /// metodo GetGrey
        /// </summary>
        /// <returns>faz a media entre red, green e blue somando os 3 e dividindo o resultado por 3</returns>
        public int GetGrey()
        {
            return (red + green + blue) / 3;
        }
    }

    /// <summary>
    /// class Sphere para definir cor e raio de uma esfera, e para contar nº de vezes atirada
    /// </summary>
    public class Sphere
    {
        private Color color;
        private double radius;
        private int timesThrown;
    
    //construtor para raio e cor de uma esfera
        public Sphere(Color color, double radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }
    }
}