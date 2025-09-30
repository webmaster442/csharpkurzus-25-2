namespace Calculator.Core.Tokens;

internal sealed class NumberToken : IToken
{
    private readonly double _value;

    public NumberToken(double value)
    {
        _value = value;
    }

    public void Apply(INumberStack stack)
    {
        stack.Push(_value);
    }
}
