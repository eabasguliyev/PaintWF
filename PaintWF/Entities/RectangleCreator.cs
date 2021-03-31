using PaintWF.Interfaces;

namespace PaintWF.Entities
{
    public class RectangleCreator : ICreator
    {
        public IFigure CreateFigure()
        {
            return new Rectangle();
        }
    }
}