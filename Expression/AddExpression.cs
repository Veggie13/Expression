using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    public class AddExpression : Expression
    {
        private Expression _addend1, _addend2;

        public AddExpression(Expression addend1, Expression addend2)
        {
            _addend1 = addend1;
            _addend2 = addend2;
        }

        public double Evaluate(IDictionary<string, double> systemState)
        {
            return _addend1.Evaluate(systemState) + _addend2.Evaluate(systemState);
        }

        public Expression Differential()
        {
            return _addend1.Differential() + _addend2.Differential();
        }

        public Expression Derivative(string referenceVar)
        {
            return _addend1.Derivative(referenceVar) + _addend2.Derivative(referenceVar);
        }
    }
}
