namespace Calculator.Core.Tokens.Operators;

internal abstract class GreedyOperator : Operator
{
    public override void Apply(INumberStack stack)
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Not enough values on the stack.");
        }

        List<double> values = [];

        while (stack.Count > 0)
        {
            values.Add(stack.Pop());
        }

        double result = Apply(values);
        stack.Push(result);
    }

    protected abstract double Apply(IReadOnlyList<double> values);
}
