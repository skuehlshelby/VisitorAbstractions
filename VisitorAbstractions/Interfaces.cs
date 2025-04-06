namespace Abstractions.Functional
{
    public sealed class Nothing
    {
        private Nothing() { }
        public static readonly Nothing Instance = new();
    }
}

namespace Abstractions.Visitors.Interfaces
{
    #region T = 1
    
    public interface IVisitable<out T1>
    {
        TReturn Accept<TReturn>(IVisitor<T1, TReturn> visitor);
    }

    public interface IVisitableFactory<T1>
    {
        IVisitable<T1> Create(T1 instance);
    }

    public interface IVisitor<in T1, TReturn>
    {
        TReturn Visit(T1 instance);
    }

    #endregion
    
    #region T = 2
    
    public interface IVisitable<out T1, out T2>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2>
    {
        IVisitable<T1, T2> Create(T1 instance);
        IVisitable<T1, T2> Create(T2 instance);
    }

    public interface IVisitor<in T1, in T2, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
    }

    public interface I1x1Visitor<in T1, in T2, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
    }

    #endregion
    
    #region T = 3
    
    public interface IVisitable<out T1, out T2, out T3>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3>
    {
        IVisitable<T1, T2, T3> Create(T1 instance);
        IVisitable<T1, T2, T3> Create(T2 instance);
        IVisitable<T1, T2, T3> Create(T3 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
    }

    public interface I1x2Visitor<in T1, in T2, in T3, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
    }

    public interface I2x1Visitor<in T1, in T2, in T3, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T2 left, T3 right);
    }

    #endregion
    
    #region T = 4
    
    public interface IVisitable<out T1, out T2, out T3, out T4>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4>
    {
        IVisitable<T1, T2, T3, T4> Create(T1 instance);
        IVisitable<T1, T2, T3, T4> Create(T2 instance);
        IVisitable<T1, T2, T3, T4> Create(T3 instance);
        IVisitable<T1, T2, T3, T4> Create(T4 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
    }

    public interface I1x3Visitor<in T1, in T2, in T3, in T4, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
    }

    public interface I2x2Visitor<in T1, in T2, in T3, in T4, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
    }

    public interface I3x1Visitor<in T1, in T2, in T3, in T4, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T3 left, T4 right);
    }

    #endregion
    
    #region T = 5
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5>
    {
        IVisitable<T1, T2, T3, T4, T5> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5> Create(T5 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
    }

    public interface I1x4Visitor<in T1, in T2, in T3, in T4, in T5, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
    }

    public interface I2x3Visitor<in T1, in T2, in T3, in T4, in T5, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
    }

    public interface I3x2Visitor<in T1, in T2, in T3, in T4, in T5, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
    }

    public interface I4x1Visitor<in T1, in T2, in T3, in T4, in T5, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T4 left, T5 right);
    }

    #endregion
    
    #region T = 6
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6>
    {
        IVisitable<T1, T2, T3, T4, T5, T6> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6> Create(T6 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
    }

    public interface I1x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
    }

    public interface I2x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
    }

    public interface I3x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
    }

    public interface I4x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
    }

    public interface I5x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T5 left, T6 right);
    }

    #endregion
    
    #region T = 7
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T7 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
    }

    public interface I1x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
    }

    public interface I2x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
    }

    public interface I3x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
    }

    public interface I4x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
    }

    public interface I5x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
    }

    public interface I6x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T6 left, T7 right);
    }

    #endregion
    
    #region T = 8
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T8 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
    }

    public interface I1x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
    }

    public interface I2x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
    }

    public interface I3x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
    }

    public interface I4x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
    }

    public interface I5x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
    }

    public interface I6x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
    }

    public interface I7x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T7 left, T8 right);
    }

    #endregion
    
    #region T = 9
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T9 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
    }

    public interface I1x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
    }

    public interface I2x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
    }

    public interface I3x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
    }

    public interface I4x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
    }

    public interface I5x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
    }

    public interface I6x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
    }

    public interface I7x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
    }

    public interface I8x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T8 left, T9 right);
    }

    #endregion
    
    #region T = 10
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T9 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T10 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
        TReturn Visit(T10 instance);
    }

    public interface I1x9Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
    }

    public interface I2x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
    }

    public interface I3x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
    }

    public interface I4x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
    }

    public interface I5x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
    }

    public interface I6x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
    }

    public interface I7x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
    }

    public interface I8x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T8 left, T9 right);
        TReturn Visit (T8 left, T10 right);
    }

    public interface I9x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, TReturn>
    {
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T9 left, T10 right);
    }

    #endregion
    
    #region T = 11
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T9 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T10 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T11 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
        TReturn Visit(T10 instance);
        TReturn Visit(T11 instance);
    }

    public interface I1x10Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
    }

    public interface I2x9Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
    }

    public interface I3x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
    }

    public interface I4x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
    }

    public interface I5x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
    }

    public interface I6x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
    }

    public interface I7x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
    }

    public interface I8x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T8 left, T9 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
    }

    public interface I9x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T9 left, T10 right);
        TReturn Visit (T9 left, T11 right);
    }

    public interface I10x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, TReturn>
    {
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T10 left, T11 right);
    }

    #endregion
    
    #region T = 12
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T9 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T10 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T11 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T12 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
        TReturn Visit(T10 instance);
        TReturn Visit(T11 instance);
        TReturn Visit(T12 instance);
    }

    public interface I1x11Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
    }

    public interface I2x10Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
    }

    public interface I3x9Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
    }

    public interface I4x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
    }

    public interface I5x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
    }

    public interface I6x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
    }

    public interface I7x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
    }

    public interface I8x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T8 left, T9 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
    }

    public interface I9x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T9 left, T10 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
    }

    public interface I10x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T10 left, T11 right);
        TReturn Visit (T10 left, T12 right);
    }

    public interface I11x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, TReturn>
    {
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T11 left, T12 right);
    }

    #endregion
    
    #region T = 13
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T9 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T10 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T11 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T12 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T13 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
        TReturn Visit(T10 instance);
        TReturn Visit(T11 instance);
        TReturn Visit(T12 instance);
        TReturn Visit(T13 instance);
    }

    public interface I1x12Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
    }

    public interface I2x11Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
    }

    public interface I3x10Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
    }

    public interface I4x9Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
    }

    public interface I5x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
    }

    public interface I6x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
    }

    public interface I7x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
    }

    public interface I8x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T8 left, T9 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
    }

    public interface I9x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T9 left, T10 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
    }

    public interface I10x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T10 left, T11 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
    }

    public interface I11x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T11 left, T12 right);
        TReturn Visit (T11 left, T13 right);
    }

    public interface I12x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, TReturn>
    {
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T11 left, T13 right);
        TReturn Visit (T12 left, T13 right);
    }

    #endregion
    
    #region T = 14
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T9 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T10 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T11 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T12 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T13 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T14 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
        TReturn Visit(T10 instance);
        TReturn Visit(T11 instance);
        TReturn Visit(T12 instance);
        TReturn Visit(T13 instance);
        TReturn Visit(T14 instance);
    }

    public interface I1x13Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
    }

    public interface I2x12Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
    }

    public interface I3x11Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
    }

    public interface I4x10Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
    }

    public interface I5x9Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
    }

    public interface I6x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
    }

    public interface I7x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
    }

    public interface I8x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T8 left, T9 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
    }

    public interface I9x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T9 left, T10 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
    }

    public interface I10x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T10 left, T11 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
    }

    public interface I11x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T11 left, T12 right);
        TReturn Visit (T11 left, T13 right);
        TReturn Visit (T11 left, T14 right);
    }

    public interface I12x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T11 left, T13 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T12 left, T13 right);
        TReturn Visit (T12 left, T14 right);
    }

    public interface I13x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, TReturn>
    {
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T12 left, T14 right);
        TReturn Visit (T13 left, T14 right);
    }

    #endregion
    
    #region T = 15
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T9 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T10 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T11 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T12 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T13 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T14 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T15 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
        TReturn Visit(T10 instance);
        TReturn Visit(T11 instance);
        TReturn Visit(T12 instance);
        TReturn Visit(T13 instance);
        TReturn Visit(T14 instance);
        TReturn Visit(T15 instance);
    }

    public interface I1x14Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
    }

    public interface I2x13Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
    }

    public interface I3x12Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
    }

    public interface I4x11Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
    }

    public interface I5x10Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
    }

    public interface I6x9Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
    }

    public interface I7x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
    }

    public interface I8x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T8 left, T9 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
    }

    public interface I9x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T9 left, T10 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
    }

    public interface I10x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T10 left, T11 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
    }

    public interface I11x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T11 left, T12 right);
        TReturn Visit (T11 left, T13 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T11 left, T15 right);
    }

    public interface I12x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T11 left, T13 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T11 left, T15 right);
        TReturn Visit (T12 left, T13 right);
        TReturn Visit (T12 left, T14 right);
        TReturn Visit (T12 left, T15 right);
    }

    public interface I13x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T11 left, T15 right);
        TReturn Visit (T12 left, T14 right);
        TReturn Visit (T12 left, T15 right);
        TReturn Visit (T13 left, T14 right);
        TReturn Visit (T13 left, T15 right);
    }

    public interface I14x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, TReturn>
    {
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T11 left, T15 right);
        TReturn Visit (T12 left, T15 right);
        TReturn Visit (T13 left, T15 right);
        TReturn Visit (T14 left, T15 right);
    }

    #endregion
    
    #region T = 16
    
    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16>
    {
        TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor);
    }

    public interface IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T1 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T2 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T3 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T4 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T5 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T6 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T7 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T8 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T9 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T10 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T11 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T12 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T13 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T14 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T15 instance);
        IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T16 instance);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
        TReturn Visit(T8 instance);
        TReturn Visit(T9 instance);
        TReturn Visit(T10 instance);
        TReturn Visit(T11 instance);
        TReturn Visit(T12 instance);
        TReturn Visit(T13 instance);
        TReturn Visit(T14 instance);
        TReturn Visit(T15 instance);
        TReturn Visit(T16 instance);
    }

    public interface I1x15Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T2 right);
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
    }

    public interface I2x14Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T3 right);
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T3 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
    }

    public interface I3x13Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T4 right);
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T4 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T4 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
    }

    public interface I4x12Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T5 right);
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T5 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T5 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T5 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
    }

    public interface I5x11Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T6 right);
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T6 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T6 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T6 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T6 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
    }

    public interface I6x10Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T7 right);
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T7 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T7 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T7 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T7 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T7 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
    }

    public interface I7x9Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T8 right);
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T8 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T8 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T8 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T8 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T8 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T8 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
    }

    public interface I8x8Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T9 right);
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T9 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T9 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T9 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T9 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T9 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T9 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T9 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T8 left, T16 right);
    }

    public interface I9x7Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T10 right);
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T10 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T10 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T10 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T10 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T10 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T10 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T10 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T8 left, T16 right);
        TReturn Visit (T9 left, T10 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T9 left, T16 right);
    }

    public interface I10x6Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T11 right);
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T11 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T11 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T11 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T11 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T11 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T11 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T11 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T8 left, T16 right);
        TReturn Visit (T9 left, T11 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T9 left, T16 right);
        TReturn Visit (T10 left, T11 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T10 left, T16 right);
    }

    public interface I11x5Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T12 right);
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T12 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T12 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T12 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T12 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T12 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T12 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T12 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T8 left, T16 right);
        TReturn Visit (T9 left, T12 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T9 left, T16 right);
        TReturn Visit (T10 left, T12 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T10 left, T16 right);
        TReturn Visit (T11 left, T12 right);
        TReturn Visit (T11 left, T13 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T11 left, T15 right);
        TReturn Visit (T11 left, T16 right);
    }

    public interface I12x4Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T13 right);
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T13 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T13 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T13 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T13 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T13 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T13 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T13 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T8 left, T16 right);
        TReturn Visit (T9 left, T13 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T9 left, T16 right);
        TReturn Visit (T10 left, T13 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T10 left, T16 right);
        TReturn Visit (T11 left, T13 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T11 left, T15 right);
        TReturn Visit (T11 left, T16 right);
        TReturn Visit (T12 left, T13 right);
        TReturn Visit (T12 left, T14 right);
        TReturn Visit (T12 left, T15 right);
        TReturn Visit (T12 left, T16 right);
    }

    public interface I13x3Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T14 right);
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T14 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T14 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T14 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T14 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T14 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T14 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T14 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T8 left, T16 right);
        TReturn Visit (T9 left, T14 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T9 left, T16 right);
        TReturn Visit (T10 left, T14 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T10 left, T16 right);
        TReturn Visit (T11 left, T14 right);
        TReturn Visit (T11 left, T15 right);
        TReturn Visit (T11 left, T16 right);
        TReturn Visit (T12 left, T14 right);
        TReturn Visit (T12 left, T15 right);
        TReturn Visit (T12 left, T16 right);
        TReturn Visit (T13 left, T14 right);
        TReturn Visit (T13 left, T15 right);
        TReturn Visit (T13 left, T16 right);
    }

    public interface I14x2Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T15 right);
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T15 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T15 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T15 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T15 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T15 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T15 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T15 right);
        TReturn Visit (T8 left, T16 right);
        TReturn Visit (T9 left, T15 right);
        TReturn Visit (T9 left, T16 right);
        TReturn Visit (T10 left, T15 right);
        TReturn Visit (T10 left, T16 right);
        TReturn Visit (T11 left, T15 right);
        TReturn Visit (T11 left, T16 right);
        TReturn Visit (T12 left, T15 right);
        TReturn Visit (T12 left, T16 right);
        TReturn Visit (T13 left, T15 right);
        TReturn Visit (T13 left, T16 right);
        TReturn Visit (T14 left, T15 right);
        TReturn Visit (T14 left, T16 right);
    }

    public interface I15x1Visitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, TReturn>
    {
        TReturn Visit (T1 left, T16 right);
        TReturn Visit (T2 left, T16 right);
        TReturn Visit (T3 left, T16 right);
        TReturn Visit (T4 left, T16 right);
        TReturn Visit (T5 left, T16 right);
        TReturn Visit (T6 left, T16 right);
        TReturn Visit (T7 left, T16 right);
        TReturn Visit (T8 left, T16 right);
        TReturn Visit (T9 left, T16 right);
        TReturn Visit (T10 left, T16 right);
        TReturn Visit (T11 left, T16 right);
        TReturn Visit (T12 left, T16 right);
        TReturn Visit (T13 left, T16 right);
        TReturn Visit (T14 left, T16 right);
        TReturn Visit (T15 left, T16 right);
    }

    #endregion
    
}
