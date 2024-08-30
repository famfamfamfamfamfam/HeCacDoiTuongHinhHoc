using System.Drawing;

namespace TINHCHATLOP
{
    public class Shape
    {
        private string color;
        public string Color
        {
            get => color;
            set => color = value;
        }
        private bool filled;
        public bool Filled
        {
            get => filled;
            set => filled = value;
        }
        public Shape()
        {
            color = "green";
            filled = true;
        }
        public Shape(string Color, bool Filled)
        {
            color = Color;
            filled = Filled;
        }
        public override string ToString()
        {
            string chuoiin = $"A Shape with color of {color} and ";
            if (filled)
            {
                chuoiin += "filled";
            }
            else
            {
                chuoiin += "not filled";
            }
            return chuoiin;
        }
    }
}