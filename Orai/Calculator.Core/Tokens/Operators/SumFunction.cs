namespace Calculator.Core.Tokens.Operators;

internal class SumFunction : GreedyOperator
{
    protected override double Apply(IReadOnlyList<double> values)
    {
        return values.Sum();
    }
}