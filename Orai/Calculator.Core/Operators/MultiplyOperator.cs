namespace Calculator.Core.Operators
{
    public sealed class MultiplyOperator : BinaryOperator
    {
        protected override double Apply(double left, double right)
            => left * right;
    }
}


