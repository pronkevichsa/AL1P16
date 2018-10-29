using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL1P16
{
    interface IShape
    {
        void ShapeName();
        double ShapeArea();
    }

    class Circle : IShape
    {
        private int rad;
        public Circle()
        {
            this.rad = 1;
        }
        public Circle (int rad)
        {
            this.rad = rad;
        }
        public void ShapeName()
        {
            Console.WriteLine($"Circle R={this.rad}");
        }
        public double ShapeArea()
        {
            return (this.rad*this.rad*Math.PI);
        }

    }
    class Square:IShape
    {
        /// <summary>
        ///  bla bla bla 
        /// </summary>
        private int side;
        public Square()
        {
            this.side = 1;
        }
        public Square(int side)
        {
            this.side = side;
        }
        public void ShapeName()
        {
            Console.WriteLine($"Square a={this.side}");
        }

        public double ShapeArea()
        {
            return (this.side * this.side);
        }
    }
    class EquilateralTriangle:IShape
    {
        private int side;
        public EquilateralTriangle()
        {
            this.side = 1;
        }
        public EquilateralTriangle(int side)
        {
            this.side = side;
        }
        public double ShapeArea()
        {
            return (0.5*this.side*this.side);
        }
        public void ShapeName()
        {
            Console.WriteLine($"EquilateralTriangle a={this.side}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape[,] ShapeMatr = new IShape[3, 10];
           
            for (int i = 0; i < 10; i++)
            {
                ShapeMatr[0, i] = new EquilateralTriangle(i+1);
                ShapeMatr[1, i] = new Square(i+1);
                ShapeMatr[2, i] = new Circle(i+1);
            }
            for (int i = 0; i < 10; i++)
                Console.Write("{0} ", i);
            Console.WriteLine();
            Console.WriteLine("******************************************");
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write("{0} ", ShapeMatr[j, i].ShapeArea().ToString("f2"));
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
