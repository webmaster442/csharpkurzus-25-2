
using System.Globalization;

using Calculator.Core.Tokens;
using Calculator.Core.Tokens.Operators;

namespace Calculator.Core;

public class Tokenizer : ITokenizer
{
    private readonly Dictionary<string, IToken> _table;

    public Tokenizer()
    {
        _table = new Dictionary<string, IToken>()
        {
            { "+", new AddOperator() },
            { "-", new SubtractOperator() },
            { "*", new MultiplyOperator() },
            { "/", new DivideOperator() },
            { "sin", new SinusFunction() },
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
                tokens.Add(new NumberToken(number));
            }
            else
            {
                throw new InvalidOperationException($"Unknown token: {part}");
            }
        }

        return tokens;
    }
}