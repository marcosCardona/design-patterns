
namespace AppPatronesDiseño.Patrones_comportamiento._12.Visitor
{
    public class Shapes
    {
        public abstract class ShapeExpression
        {
            public abstract void Accept(IShapeVisitor shapeVisitor);
        }

        public class Circle : ShapeExpression
        {
            public double Radius;

            /// <summary>
            /// Constructor
            /// </summary>
            public Circle(double radius)
            {
                Radius = radius;
            }

            public override void Accept(IShapeVisitor shapeVisitor)
            {
                shapeVisitor.Visit(this);
            }
        }

        public class Square : ShapeExpression
        {
            public double Side;

            /// <summary>
            /// Constructor
            /// </summary>
            public Square(double side)
            {
                Side = side;
            }

            public override void Accept(IShapeVisitor shapeVisitor)
            {
                shapeVisitor.Visit(this);
            }
        }
    }
}