using System.Drawing;

namespace TINHCHATLOP
{
    public class Rectangle : Shape
    {
        private double width;
        public double GetWidth()
        {
            return width;
        }
        public virtual void SetWidth(double value)
        {
            width = value;
        }
        private double length;
        public double GetLength()
        {
            return length;
        }
        public virtual void SetLength(double value)
        {
            length = value;
        }
        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }
        public Rectangle(double Width, double Length)
        {
            width = Width;
            length = Length;
        }
        public Rectangle(double Width, double Length, string color, bool filled): base(color, filled)
        {
            width = Width;
            length = Length;
        }
        public double GetArea()
        {
            return width*length;
        }
        public double GetPerimeter()
        {
            return (width+length)*2;
        }
        public override string ToString()
        {
            return $"A Rectangle with width={width} and length={length}, which is a subclass of {base.ToString()}";
        }
    }
}