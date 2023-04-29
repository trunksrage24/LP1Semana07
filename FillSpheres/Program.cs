using System;

namespace FillSpheres
{
    /// <summary>
    /// class Program para criar esferas usando dimensao e cor, e rebentar esferas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
{
        // cria esfera red
        Sphere redSphere = new Sphere(new Color(255, 0, 0), 5.0);
        // cria esfera green
        Sphere greenSphere = new Sphere(new Color(0, 255, 0), 4.0);
        // cria esfera blue
        Sphere blueSphere = new Sphere(new Color(0, 0, 255), 3.0);

        // atirar esferas
        for (int i = 0; i < 5; i++)
        {
            redSphere.Throw();
            Console.WriteLine($"Red sphere thrown {redSphere.GetTimesThrown()} times.");

            greenSphere.Throw();
            Console.WriteLine($"Green sphere thrown {greenSphere.GetTimesThrown()} times.");

            blueSphere.Throw();
            Console.WriteLine($"Blue sphere thrown {blueSphere.GetTimesThrown()} times.");
        }

        // fura uma esfera random
        Random rnd = new Random();
        int sphereToPop = rnd.Next(1, 4);

        //caso random selecione 1 fura red
        if (sphereToPop == 1)
        {
            redSphere.Pop();
            Console.WriteLine($"Red sphere has been popped.");
        }

        //caso random selecione 2 fura green
        else if (sphereToPop == 2)
        {
            greenSphere.Pop();
            Console.WriteLine($"Green sphere has been popped.");
        }

        //caso random selecione 3 fura blue
        else if (sphereToPop == 3)
        {
            blueSphere.Pop();
            Console.WriteLine($"Blue sphere has been popped.");
        }
    }

    Console.ReadLine();
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
        
        /// <summary>
        /// metodo Pop que coloca o raio da esfera a 0
        /// </summary>
        public void Pop()
        {
            this.radius = 0;
        }

        /// <summary>
        /// metodo Throw que incrementa o nº de vezes que a esfera foi atirada se não tiver furada
        /// </summary>
        public void Throw()
        {
            if (this.radius > 0)
            {
                this.timesThrown++;
            }
        }

        /// <summary>
        /// metodo GetTimesThrown que retorna o número de vezes que a esfera foi atirada
        /// </summary>
        /// <returns></returns>
        public int GetTimesThrown()
        {
            return this.timesThrown;
        }
    }
}