using System;

namespace AppPatronesDiseño.Patrones_comportamiento._7.NullObject
{
    public class RepositoryOperation
    {
        public IOperation GetOperation(string operationType)
        {
            // Try to parse string to Enum type
            Enum.TryParse<EnumMathOperations>(operationType, out EnumMathOperations valueOperation);
            // Return object
            IOperation operationObject;

            switch (valueOperation)
            {
                case EnumMathOperations.ADDITION:
                    operationObject = new AdditionOperation();
                    break;
                case EnumMathOperations.SUBTRACTION:
                    operationObject = new SubtractionOperation();
                    break;
                case EnumMathOperations.MULTIPLICATION:
                    operationObject = new MultiplicationOperation();
                    break;
                case EnumMathOperations.DIVISION:
                    operationObject = new DivisionOperation();
                    break;
                default:
                    operationObject = NullOperation.Instance;
                    break;
            }

            return operationObject;
        }
    }
}