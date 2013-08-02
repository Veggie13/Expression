using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    public abstract class Expression
    {
        public abstract double Evaluate(IDictionary<string, double> systemState);
        public abstract Expression Differential();
        public abstract Expression Derivative(string referenceVar);

        public static Expression operator +(Expression addend1, Expression addend2)
        {
            return new AddExpression(addend1, addend2);
        }

        public static Expression operator -(Expression minuend1, Expression minuend2)
        {
            return new MinusExpression(minuend1, minuend2);
        }

        public static Expression operator *(Expression multiplicand1, Expression multiplicand2)
        {
            return new MultiplyExpression(multiplicand1, multiplicand2);
        }
    }
}
