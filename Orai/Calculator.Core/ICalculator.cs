namespace Calculator.Core;

internal interface ICalculator
{
    Result<double, string> Calculate(string expression);
}
