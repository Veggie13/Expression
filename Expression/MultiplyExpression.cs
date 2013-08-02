using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    public class MultiplyExpression : Expression
    {
        private Expression _multiplicand1, _multiplicand2;

        public MultiplyExpression(Expression multiplicand1, Expression multiplicand2)
        {
            _multiplicand1 = multiplicand1;
            _multiplicand2 = multiplicand2;
        }

        public double Evaluate(IDictionary<string, double> systemState)
        {
            return _multiplicand1.Evaluate(systemState) * _multiplicand2.Evaluate(systemState);
        }

        public Expression Differential()
        {
            return _multiplicand1 * _multiplicand2.Differential() +
                _multiplicand2 * _multiplicand1.Differential();
        }

        public Expression Derivative(string referenceVar)
        {
            return _multiplicand1 * _multiplicand2.Derivative(referenceVar) +
                _multiplicand2 * _multiplicand1.Derivative(referenceVar);
        }
    }
}
