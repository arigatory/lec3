using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lec3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Draw();

            Square square = new Square();
            square.Draw();

            Circle circle = new Circle();
            circle.Draw();

            Shape[] shapes = new Shape[]
            {
                new Shape(), new Circle(), new Square(), new Rectange(), new Point(),  
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();
            }

            Console.ReadLine();
        }

        class Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public virtual void Draw()
            {
                Console.WriteLine("Figure");
            }
        }

        class Rectange : Shape
        {
            public override void Draw()
            {
                Console.WriteLine(nameof(Rectange));
            }
        }

        class Square : Rectange
        {
            public override void Draw()
            {
                Console.WriteLine("Square");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle");
            }
        }

        class Point : Square
        {
            public new void Draw()
            {
                Console.WriteLine(nameof(Rectange));
            }
        }
    }
}
