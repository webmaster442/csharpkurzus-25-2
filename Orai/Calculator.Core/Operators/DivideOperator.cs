namespace Calculator.Core.Operators
{
    public sealed class DivideOperator : BinaryOperator
    {
        protected override double Apply(double left, double right)
            => left / right;
    }
}


