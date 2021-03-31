using PaintWF.Interfaces;

namespace PaintWF.Entities
{
    public class TriangleCreator:ICreator
    {
        public IFigure CreateFigure()
        {
            return new Triangle();
        }
    }
}