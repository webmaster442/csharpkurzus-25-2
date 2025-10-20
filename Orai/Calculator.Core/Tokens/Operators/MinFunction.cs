namespace Calculator.Core.Tokens.Operators;

internal class MinFunction : GreedyOperator
{
    protected override double Apply(IReadOnlyList<double> values)
    {
        return values.Min();
    }
}
