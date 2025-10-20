using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Tokens.Operators;
internal class RootMeanSquareFunction : GreedyOperator
{
    protected override double Apply(IReadOnlyList<double> values)
    {
        if (values.Count == 0)
        {
            throw new InvalidOperationException("No values to calculate root mean square.");
        }

        double sumOfSquares = values.Sum(value => value * value);

        return Math.Sqrt(sumOfSquares / values.Count);
    }
}
