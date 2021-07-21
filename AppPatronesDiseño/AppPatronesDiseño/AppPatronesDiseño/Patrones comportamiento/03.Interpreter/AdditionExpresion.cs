
namespace AppPatronesDiseño.Patrones_comportamiento._3.Interpreter
{
    public class AdditionExpresion : IExpresion<float>
    {
        private IExpresion<float> _FirstExpression;
        private IExpresion<float> _SecondExpression;

        public AdditionExpresion(IExpresion<float> firstExpression, IExpresion<float> secondExpression)
        {
            _FirstExpression = firstExpression;
            _SecondExpression = secondExpression;
        }

        public float Interpret()
        {
            return _FirstExpression.Interpret() + _SecondExpression.Interpret();
        }
    }
}