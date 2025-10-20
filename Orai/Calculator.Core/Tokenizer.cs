
using System.Globalization;

using Calculator.Core.Tokens;
using Calculator.Core.Tokens.Operators;

using static System.StringSplitOptions;

namespace Calculator.Core;

internal class Tokenizer : ITokenizer
{
    private readonly Dictionary<string, IToken> _table;

    public Tokenizer()
    {
        _table = new Dictionary<string, IToken>()
        {
            ["+"] = new AddOperator(),
            ["-"] = new SubtractOperator(),
            ["*"] = new MultiplyOperator(),
            ["/"] = new DivideOperator(),
            ["sin"] = new SinusFunction(),
            ["avg"] = new AverageFunction(),
            ["max"] = new MaxFunction(),
            ["min"] = new MinFunction(),
            ["sum"] = new SumFunction(),
            ["median"] = new MedianFunction(),
            ["mode"] = new ModeFunction(),
            ["rms"] = new RootMeanSquareFunction()
        };
    }

    public IEnumerable<IToken> Tokenize(string expression)
    {
        foreach (string part in expression.Split(' ', RemoveEmptyEntries | TrimEntries))
        {
            if (_table.TryGetValue(part, out IToken? value))
            {
                yield return value;
            }
            else if (double.TryParse(part, CultureInfo.InvariantCulture, out double number))
            {
                yield return new NumberToken(number);
            }
            else
            {
                throw new InvalidOperationException($"Unknown token: {part}");
            }
        }
    }
}