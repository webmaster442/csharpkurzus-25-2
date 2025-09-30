using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core;

public class Result<TSucces, TError>
{
    private readonly TSucces? _success;
    private readonly TError? _error;

    public bool IsSuccess { get; }
    public bool IsError => !IsSuccess;

    public Result(TSucces success)
    {
        _success = success;
        IsSuccess = true;
    }

    public Result(TError error)
    {
        _error = error;
        IsSuccess = false;
    }

    public void Handle(Action<TSucces> successAction, Action<TError> errorAction)
    {
        if (IsSuccess && _success is not null)
        {
            successAction(_success);
        }
        else if (_error is not null)
        {
            errorAction(_error);
        }
        throw new InvalidOperationException("Result is in an invalid state.");
    }
}
