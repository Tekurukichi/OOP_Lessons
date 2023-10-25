using System;

namespace Lab6_1
{
    public class Calculator<T>
    {
        public delegate T ArithmeticOperation(T a, T b);

        public ArithmeticOperation Addition { get; set; }
        public ArithmeticOperation Subtraction { get; set; }
        public ArithmeticOperation Multiplication { get; set; }
        public ArithmeticOperation Division { get; set; }

        public Calculator(ArithmeticOperation addition, ArithmeticOperation subtraction, ArithmeticOperation multiplication, ArithmeticOperation division)
        {
            Addition = addition;
            Subtraction = subtraction;
            Multiplication = multiplication;
            Division = division;
        }

        public T PerformOperation(T a, T b, ArithmeticOperation operation)
        {
            if (operation != null)
            {
                return operation(a, b);
            }
            else
            {
                throw new InvalidOperationException("Operation not defined.");
            }
        }
    }
}