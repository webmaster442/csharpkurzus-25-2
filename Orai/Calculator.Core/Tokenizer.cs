
using System.Globalization;

using Calculator.Core.Operators;

namespace Calculator.Core;

public class Tokenizer : ITokenizer
{
    private readonly INumberStack _stack;
    private readonly Dictionary<string, IToken> _table;

    public Tokenizer(INumberStack stack)
    {
        _stack = stack;
        _table = new Dictionary<string, IToken>()
        {
            { "+", new AddOperator() },
            { "-", new SubtractOperator() },
            { "*", new MultiplyOperator() },
            { "/", new DivideOperator() },
        };
    }

    public IEnumerable<IToken> Tokenize(string expression)
    {
        List<IToken> tokens = new();
        string[] parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries
                                               | StringSplitOptions.TrimEntries);

        foreach (string part in parts)
        {
            if (_table.ContainsKey(part))
            {
                tokens.Add(_table[part]);
            }
            else if (double.TryParse(part, CultureInfo.InvariantCulture, out double number))
            {
                _stack.Push(number);
            }
            else
            {
                throw new InvalidOperationException($"Unknown token: {part}");
            }
        }

        return tokens;
    }
}