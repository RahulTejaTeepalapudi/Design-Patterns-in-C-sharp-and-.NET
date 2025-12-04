using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public class Product(string name, Color color, Size size)
    {
        public string Name = name;
        public Color Color = color;
        public Size Size = size;
    }
}
