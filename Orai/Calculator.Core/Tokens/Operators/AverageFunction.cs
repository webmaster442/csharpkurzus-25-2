namespace Calculator.Core.Tokens.Operators;

internal class AverageFunction : GreedyOperator
{
    protected override double Apply(IReadOnlyList<double> values)
    {
        return values.Average();
    }
}
