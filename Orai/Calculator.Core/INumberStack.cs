namespace Calculator.Core
{
    public interface INumberStack
    {
        double Pop();
        void Push(double number);
        int Count { get; }
    }
}
