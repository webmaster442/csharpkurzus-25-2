namespace Calculator.Core.Tokens.Operators;

public sealed class MultiplyOperator : BinaryOperator
{
    protected override double Apply(double left, double right)
        => left * right;
}


