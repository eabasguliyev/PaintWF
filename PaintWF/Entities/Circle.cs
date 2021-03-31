using System.Drawing;
using PaintWF.Interfaces;

namespace PaintWF.Entities
{
    public class Circle:IFigure
    {
        public string Name { get; set; }
        public Point Point { get; set; }
        public Size Size { get; set; }
        public bool IsFilled { get; set; }
        public Color Color { get; set; }
    }
}