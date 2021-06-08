using System;

namespace ColorBalls
{
    public class Program
    {
        static void Main(string[] args)
        {
            Color green = new Color(0, 255, 0);
            Color white = new Color(255, 255, 255);

            Ball bigGreen = new Ball(green, 5);
            Ball littleWhite = new Ball(white, 2);

            Console.WriteLine("Greenball has " + green.GetRed() + ", " + green.GetBlue() + ", " + green.GetBlue());

            bigGreen.Throw();
            bigGreen.Throw();
            bigGreen.Throw();
            bigGreen.Throw();

            Console.WriteLine(bigGreen.GetTimeThrow());

            littleWhite.Throw();
            littleWhite.Throw();
            littleWhite.Throw();

            Console.WriteLine(littleWhite.GetTimeThrow());

            littleWhite.Pop();

            littleWhite.Throw();
            littleWhite.Throw();
            littleWhite.Throw();

            Console.WriteLine(littleWhite.GetTimeThrow());


        }
    }
}
