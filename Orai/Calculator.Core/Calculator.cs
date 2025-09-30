using Calculator.Core.Tokens;

namespace Calculator.Core;

public class Calculator : ICalculator
{
    private readonly ITokenizer _tokenizer;
    private readonly INumberStack _numberStack;

    public Calculator(ITokenizer tokenizer, INumberStack numberStack)
    {
        _tokenizer = tokenizer;
        _numberStack = numberStack;
    }

    public Result<double, string> Calculate(string expression)
    {
        try
        {
            foreach (IToken token in _tokenizer.Tokenize(expression))
            {
                token.Apply(_numberStack);
            }
            return new Result<double, string>(_numberStack.Pop());
        }
        catch (InvalidOperationException ex)
        {
            return new Result<double, string>(ex.Message);
        }
    }
}