
namespace AppPatronesDiseño.Patrones_comportamiento._12.Visitor
{
    public interface IShapeVisitor
    {
        void Visit(Shapes.Circle circle);
        void Visit(Shapes.Square square);
    }
}