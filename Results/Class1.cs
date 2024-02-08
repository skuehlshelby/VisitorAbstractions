using Abstractions.Visitors.Interfaces;

namespace Results
{
    public interface IResult
    {
        bool IsSuccess { get; }
        bool IsFailure { get; }
    }

    public interface IResult<out Success> : IResult, IVisitable<Success>
    {

    }

    public interface IResult<S1, E1> : IResult, IVisitable<S1, E1> where E1 : Exception
    {
        IResult<S2, E1> Bind<S2>(Func<S1, S2> success);
        IResult<S1, E2> Bind<E2>(Func<E1, E2> error) where E2 : Exception;
        IResult<S2, E1> Bind<S2>(Func<S1, IResult<S2, E1>> success);
        IResult<S2, E1> Bind<S2, E2>(Func<S1, S2> success, Func<E1, E1> error) where E2 : Exception;
        IResult<S2, E1> Bind<S2, E2>(Func<S1, IResult<S2, E2>> success, Func<E1, IResult<S2, E2>> error) where E2 : Exception;
    }

    public interface IResult<out Success, out Exception1, out Exception2> : IResult, IVisitable<Success, Exception> where Exception1 : Exception where Exception2 : Exception
    {

    }
}
