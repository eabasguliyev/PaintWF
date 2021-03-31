using PaintWF.Interfaces;

namespace PaintWF.Entities
{
    public class CircleCreator:ICreator
    {
        public IFigure CreateFigure()
        {
            return new Circle();
        }
    }
}