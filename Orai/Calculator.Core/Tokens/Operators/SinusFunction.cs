namespace Calculator.Core.Tokens.Operators;

public sealed class SinusFunction : UnaryOperator
{
    protected override double Apply(double value)
    {
        return Math.Sin(value);
    }
}
