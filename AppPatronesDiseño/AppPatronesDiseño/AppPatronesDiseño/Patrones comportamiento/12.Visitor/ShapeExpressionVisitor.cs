using System;

namespace AppPatronesDiseño.Patrones_comportamiento._12.Visitor
{
    public class ShapeExpressionVisitor : IShapeVisitor
    {
        public void Visit(Shapes.Circle circle)
        {
            Console.WriteLine($"Circle Area: {Math.PI * (circle.Radius * circle.Radius)}");
        }

        public void Visit(Shapes.Square square)
        {
            Console.WriteLine($"Square Area: {square.Side * square.Side}");
        }
    }
}