namespace Calculator.Core.Tokens.Operators;

internal class ModeFunction : GreedyOperator
{
    protected override double Apply(IReadOnlyList<double> values)
    {
        if (values.Count == 0)
        {
            throw new InvalidOperationException("No values to calculate mode.");
        }

        return values
            .GroupBy(value => value)
            .OrderByDescending(group => group.Count())
            .ThenBy(group => group.Key)
            .First()
            .Key;
    }
}
