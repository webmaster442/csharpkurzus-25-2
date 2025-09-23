namespace Calculator.Core.Operators
{
    public sealed class SubtractOperator : BinaryOperator
    {
        protected override double Apply(double left, double right)
            => left - right;
    }
}


