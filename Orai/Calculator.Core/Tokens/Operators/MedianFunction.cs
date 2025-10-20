using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Tokens.Operators;
internal class MedianFunction : GreedyOperator
{
    protected override double Apply(IReadOnlyList<double> values)
    {
        List<double> sortedValues = [.. values.Order()];
        int count = sortedValues.Count;

        if (count == 0)
        {
            throw new InvalidOperationException("No values to calculate median.");
        }

        if (count % 2 == 1)
        {
            return sortedValues[count / 2];
        }
        else
        {
            double mid1 = sortedValues[(count / 2) - 1];
            double mid2 = sortedValues[count / 2];
            return (mid1 + mid2) / 2.0;
        }
    }
}
