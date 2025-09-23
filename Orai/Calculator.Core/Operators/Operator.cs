namespace Calculator.Core.Operators
{
    public abstract class Operator : IToken
    {
        public abstract void Apply(INumberStack stack);
    }
}
