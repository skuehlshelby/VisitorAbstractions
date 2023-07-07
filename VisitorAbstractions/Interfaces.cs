namespace VisitorAbstractions
{
    public interface IVisitableII<out T1, out T2>
    {
        void Accept(IAction<T1, T2> visitor);
        TReturn Accept<TReturn>(IFunc<TReturn, T1, T2> visitor);
    }

    public interface IFunc<out TReturn, in T1, in T2>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
    }

    public interface IAction<in T1, in T2>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
    }

    public interface IVisitable<out T1, out T2>
    {
        void Accept(IVisitor<T1, T2> visitor);
    }

    public interface IVisitor<in T1, in T2>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
    }

    public interface IVisitableExtended<out T1, out T2> : IVisitable<T1, T2>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
    }

    public interface IVisitable<out T1, out T2, out T3>
    {
        void Accept(IVisitor<T1, T2, T3> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3> : IVisitable<T1, T2, T3>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
    }

    public interface IVisitable<out T1, out T2, out T3, out T4>
    {
        void Accept(IVisitor<T1, T2, T3, T4> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4> : IVisitable<T1, T2, T3, T4>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
    }

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5> : IVisitable<T1, T2, T3, T4, T5>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
    }

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6> : IVisitable<T1, T2, T3, T4, T5, T6>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
    }

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7> : IVisitable<T1, T2, T3, T4, T5, T6, T7>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
    {
        TReturn Visit(T1 instance);
        TReturn Visit(T2 instance);
        TReturn Visit(T3 instance);
        TReturn Visit(T4 instance);
        TReturn Visit(T5 instance);
        TReturn Visit(T6 instance);
        TReturn Visit(T7 instance);
    }

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
        void Visit(T10 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
        void Visit(T10 instance);
        void Visit(T11 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
        void Visit(T10 instance);
        void Visit(T11 instance);
        void Visit(T12 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
        void Visit(T10 instance);
        void Visit(T11 instance);
        void Visit(T12 instance);
        void Visit(T13 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
        void Visit(T10 instance);
        void Visit(T11 instance);
        void Visit(T12 instance);
        void Visit(T13 instance);
        void Visit(T14 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
        void Visit(T10 instance);
        void Visit(T11 instance);
        void Visit(T12 instance);
        void Visit(T13 instance);
        void Visit(T14 instance);
        void Visit(T15 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
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

    public interface IVisitable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16>
    {
        void Accept(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> visitor);
    }

    public interface IVisitor<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
        void Visit(T4 instance);
        void Visit(T5 instance);
        void Visit(T6 instance);
        void Visit(T7 instance);
        void Visit(T8 instance);
        void Visit(T9 instance);
        void Visit(T10 instance);
        void Visit(T11 instance);
        void Visit(T12 instance);
        void Visit(T13 instance);
        void Visit(T14 instance);
        void Visit(T15 instance);
        void Visit(T16 instance);
    }

    public interface IVisitableExtended<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        TReturn Accept<TReturn>(IVisitorExtended<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> visitor);
    }

    public interface IVisitorExtended<out TReturn, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
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
}