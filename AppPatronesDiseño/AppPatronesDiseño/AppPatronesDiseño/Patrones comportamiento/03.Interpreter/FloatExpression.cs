using System;

namespace AppPatronesDiseño.Patrones_comportamiento._3.Interpreter
{
    public class FloatExpression : IExpresion<float>
    {
        private float _Number;

        public FloatExpression(int number) => _Number = Convert.ToSingle(number);
        public FloatExpression(float number) => _Number = number;
        public FloatExpression(decimal number) => _Number = Convert.ToSingle(number);
        public FloatExpression(double number) => _Number = Convert.ToSingle(number);
        public FloatExpression(string number) { float.TryParse(number, out float result); _Number = result; }

        public float Interpret()
        {
            return _Number;
        }
    }
}