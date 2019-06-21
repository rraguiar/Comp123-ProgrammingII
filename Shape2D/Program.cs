using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Shape2D
{
    interface IDrawable
    { void Draw(Graphics g); }

    interface IWriteable
    { void Write(TextWriter writer); }

    abstract class Parent : IDrawable
    {
        protected Color Color { get; }
        protected bool Filled { get; }
        protected Rectangle Rectangle { get; }

        public Parent(Color color, bool filled, Rectangle rectangle)
        {
            this.Color = color;
            this.Filled = filled;
            this.Rectangle = rectangle;
        }
        public abstract void Draw(Graphics graphics);
    }

    class DrawableRectangle : Parent, IWriteable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle)
        { }
        public override void Draw(Graphics g)
        {
            if (Filled == true)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }
        }
        public void Write(TextWriter writer)
        {
            Console.WriteLine($"Rectangle: {Color.ToKnownColor()}, {(Filled ? "Filled" : "Not Filled")}, {Rectangle}.");
        }
    }

    class DrawableEllipse : Parent, IDrawable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle) { }

        public override void Draw(Graphics g)
        {
            if (Filled == true)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawEllipse(pen, Rectangle);
            }
        }

    }

    class DrawableLine : IDrawable, IWriteable
    {
        protected Color Color { get; }
        protected Point Start { get; }
        protected Point End { get; }
        public DrawableLine(Color color, Point start, Point end)
        {
            this.Color = color;
            this.Start = start;
            this.End = end;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color);
            g.DrawLine(pen, Start, End);
        }
        public void Write(TextWriter writer)
        {
            Console.WriteLine($"Line: {Color.ToKnownColor()}, {Start}, {End}.");
        }
    }

    class DrawableBezier : IDrawable, IWriteable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color color, Point start, Point end, Point first, Point second)
        {
            this.color = color;
            this.controlFirst = first;
            this.controlSecond = second;
            this.curveEnd = end;
            this.curveStart = start;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen, curveStart, curveEnd);
        }
        
        public void Write(TextWriter writer)
        {
            Console.WriteLine($"Bezier: {color.ToKnownColor()}, {curveStart}, {curveEnd}, {controlFirst}, {controlSecond}.");
        }
        
    }

    class DrawableArc : Parent, IWriteable
    {
        protected float Start;
        protected float End;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end)
            : base (color, filled, rectangle)
        {
            this.Start = start;
            this.End = end;
        }

        public override void Draw(Graphics g)
        {
            if (Filled == true)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillPie(brush, Rectangle, Start, End);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawArc(pen, Rectangle, Start, End);
            }

        }

        public void Write(TextWriter writer)
        {
            Console.WriteLine($"Arc: {Color.ToKnownColor()}, {(Filled ? "Filled" : "Not Filled")}, {Rectangle}, Start:{Start}, End:{End}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //interfaces are types.
            List<IDrawable> face = new List<IDrawable>();
            face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(75, 160, 40, 70)));      //left ear
            face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(75, 160, 40, 70))); //left ear
            face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(285, 160, 40, 70)));     //right ear
            face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(285, 160, 40, 70)));//right ear
            face.Add(new DrawableRectangle(Color.Salmon, true, new Rectangle(100, 100, 200, 300))); //face
            face.Add(new DrawableRectangle(Color.White, true, new Rectangle(140, 165, 45, 60)));    //right eye
            face.Add(new DrawableRectangle(Color.White, true, new Rectangle(220, 165, 45, 60)));    //left eye
            face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(150, 183, 25, 40)));    //right pupil
            face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(230, 183, 25, 40)));    //left pupil
            face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(90, 10, 220, 120)));    //hat top
            face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(10, 100, 380, 20)));    //hat rim

            face.Add(new DrawableBezier(Color.Black, new Point(195, 240), new Point(215, 240), new Point(135, 280), new Point(275, 280))); //nose

            face.Add(new DrawableEllipse(Color.Red, false, new Rectangle(150, 300, 100, 35)));      //lips
            face.Add(new DrawableEllipse(Color.Wheat, true, new Rectangle(160, 305, 80, 25)));      //mouth
            face.Add(new DrawableLine(Color.Red, new Point(105, 30), new Point(105, 100)));         //lines
            face.Add(new DrawableLine(Color.Orange, new Point(127, 30), new Point(127, 100)));      //lines
            face.Add(new DrawableLine(Color.Yellow, new Point(155, 30), new Point(155, 100)));      //lines
            face.Add(new DrawableLine(Color.Green, new Point(200, 30), new Point(200, 100)));       //lines
            face.Add(new DrawableLine(Color.Blue, new Point(245, 30), new Point(245, 100)));        //lines
            face.Add(new DrawableLine(Color.Indigo, new Point(273, 30), new Point(273, 100)));      //lines
            face.Add(new DrawableLine(Color.Violet, new Point(295, 30), new Point(295, 100)));      //lines

            face.Add(new DrawableArc(Color.AliceBlue, true, new Rectangle(50, 50, 200, 300), 0, 180)); //arc

            int width = 400, length = 450;

            using (Bitmap bmp = new Bitmap(width, length))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    foreach (var item in face)
                    {
                        item.Draw(g);
                        if (item is IWriteable)
                        {
                            ((IWriteable)item).Write(System.Console.Out);
                        }
                    }
                    bmp.Save("face.png", ImageFormat.Png);
                }
            }

        }
    }
}
