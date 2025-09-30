namespace Calculator.Core.Tokens.Operators;

public sealed class DivideOperator : BinaryOperator
{
    protected override double Apply(double left, double right)
        => left / right;
}


