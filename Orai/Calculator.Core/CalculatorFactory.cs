namespace Calculator.Core;

public static class CalculatorFactory
{
    public static ICalculator Create()
    {
        ITokenizer tokenizer = new Tokenizer();
        INumberStack numberStack = new NumberStack();

        return new Calculator(tokenizer, numberStack);
    }
}
