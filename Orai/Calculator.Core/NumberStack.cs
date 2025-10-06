namespace Calculator.Core;

internal class NumberStack : GenericStack<double>, INumberStack
{
    public int Count => this.AsEnumerable().Count();
}
