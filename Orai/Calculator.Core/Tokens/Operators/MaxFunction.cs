namespace Calculator.Core.Tokens.Operators;

internal class MaxFunction : GreedyOperator
{
    protected override double Apply(IReadOnlyList<double> values)
    {
        return values.Max();
    }
}
