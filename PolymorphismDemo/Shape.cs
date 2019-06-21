using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    abstract class Shape
    {
        public string Name { get; protected set; } //readonly property
        abstract public double Area { get; }
        public Shape (string parameter)
        { this.Name = parameter; }
        public override string ToString()
        {
            return $"{Name}, {Area:N2}";
        }
    }

    class Square : Shape
    {
        protected double Length { get; }
        public override double Area { get { return Length * Length; } }
        public Square(double Length) : base("square")
        {
            this.Length = Length;
        }
        public Square(string name, double length) : base(name)
        {
            this.Length = length;
        }
    }

    class Circle : Square
    {
        public override double Area { get { return Math.PI * (Math.Pow(Length, 2)); } }
        public Circle(double Length)
            : base("circle", Length)
        { }
    }

    class Rectangle : Shape
    {
        protected double Width { get; set; }
        protected double Height { get; set; }
        public override double Area { get { return Width * Height; } }
        public Rectangle(double length, double width)
           : base("rectangle")
        {
            this.Width = width;
            this.Height = length;
        }
        public Rectangle(string name, double length, double width)
            : base(name)
        {
            this.Width = width;
            this.Height = length;
        }
    }

    class Ellipse : Rectangle
    {
        public override double Area { get { return Math.PI * Width * Height; } }
        public Ellipse(double height, double width)
            : base("Ellipse", height, width)
        { }

    }

    class Triangle : Rectangle
    {
        public override double Area { get { return Width * Height * 0.5; } }
        public Triangle (double length, double Height)
            : base ("Triangle", length, Height)
        { }
    }

    class Diamond : Rectangle
    {
        public override double Area { get { return (Width*Height); } }
        public Diamond(double height, double width)
            : base("Diamond", height, width)
        { }
    }
}
