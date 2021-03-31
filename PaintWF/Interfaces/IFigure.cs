using System.Drawing;

namespace PaintWF.Interfaces
{
    public interface IFigure
    {
        string Name { get; set; }
        Point Point { get; set; }
        Size Size { get; set; }
        bool IsFilled { get; set; }
        Color Color { get; set; }
    }
}