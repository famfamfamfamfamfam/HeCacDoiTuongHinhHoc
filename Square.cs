namespace TINHCHATLOP
{
    public class Square : Rectangle
    {
        public Square(){}
        public Square (double side) : base(side,side){}
        public Square(double side, string c, bool f) : base(side, side, c, f){}
        public double GetSide()
        {
            return GetWidth();
        }
        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }
        public override void SetWidth(double value)
        {
            SetSide(value);
        }
        public override void SetLength(double value)
        {
            SetSide(value);
        }
        public override string ToString()
        {
            return $"A Square with side={GetSide()}, which is a subclass of {base.ToString()}";
        }
    }
}