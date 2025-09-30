namespace Calculator.Core.Tokens.Operators;

public sealed class AddOperator : BinaryOperator
{
    protected override double Apply(double left, double right)
        => left + right;
}


