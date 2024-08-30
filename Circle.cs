namespace TINHCHATLOP
{
    public class Circle : Shape
    {
        private double radius;
        public double r
        {
            get => radius;
            set => radius = value;
        }
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double r)
        {
            radius = r;
        }
        public Circle(double r, string Color, bool Filled) : base(Color, Filled)
        {
            radius = r;
        }
        public double GetArea()
        {
            return Math.Pow(radius,2)*Math.PI;
        }
        public double GetPerimeter()
        {
            return radius*2*Math.PI;
        }
        public override string ToString()
        {
            return $"A Circle with radius={radius}, which is a subclass of {base.ToString()}";
        }
    }
}