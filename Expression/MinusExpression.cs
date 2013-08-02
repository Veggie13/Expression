using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    public class MinusExpression : Expression
    {
        private Expression _minuend1, _minuend2;

        public MinusExpression(Expression minuend1, Expression minuend2)
        {
            _minuend1 = minuend1;
            _minuend2 = minuend2;
        }

        public double Evaluate(IDictionary<string, double> systemState)
        {
            return _minuend1.Evaluate(systemState) - _minuend2.Evaluate(systemState);
        }

        public Expression Differential()
        {
            return _minuend1.Differential() - _minuend2.Differential();
        }

        public Expression Derivative(string referenceVar)
        {
            return _minuend1.Derivative(referenceVar) - _minuend2.Derivative(referenceVar);
        }
    }
}
