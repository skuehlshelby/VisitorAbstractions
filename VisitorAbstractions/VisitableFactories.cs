using System;
using Abstractions.SumTypes.Variants;
using Abstractions.Visitors.Interfaces;

namespace Abstractions.Visitors.FactoryMethods
{
    #region T = 1

    public sealed class VisitableFactory<T1> : IVisitableFactory<T1>
    {
        public IVisitable<T1> Create(T1 instance) => new Variant<T1>(instance);
    }

    #endregion

    #region T = 2

    public sealed class VisitableFactory<T1, T2> : IVisitableFactory<T1, T2>
    {
        public IVisitable<T1, T2> Create(T1 instance) => new Variant<T1, T2>(instance);
        public IVisitable<T1, T2> Create(T2 instance) => new Variant<T1, T2>(instance);
    }

    #endregion

    #region T = 3

    public sealed class VisitableFactory<T1, T2, T3> : IVisitableFactory<T1, T2, T3>
    {
        public IVisitable<T1, T2, T3> Create(T1 instance) => new Variant<T1, T2, T3>(instance);
        public IVisitable<T1, T2, T3> Create(T2 instance) => new Variant<T1, T2, T3>(instance);
        public IVisitable<T1, T2, T3> Create(T3 instance) => new Variant<T1, T2, T3>(instance);
    }

    #endregion

    #region T = 4

    public sealed class VisitableFactory<T1, T2, T3, T4> : IVisitableFactory<T1, T2, T3, T4>
    {
        public IVisitable<T1, T2, T3, T4> Create(T1 instance) => new Variant<T1, T2, T3, T4>(instance);
        public IVisitable<T1, T2, T3, T4> Create(T2 instance) => new Variant<T1, T2, T3, T4>(instance);
        public IVisitable<T1, T2, T3, T4> Create(T3 instance) => new Variant<T1, T2, T3, T4>(instance);
        public IVisitable<T1, T2, T3, T4> Create(T4 instance) => new Variant<T1, T2, T3, T4>(instance);
    }

    #endregion

    #region T = 5

    public sealed class VisitableFactory<T1, T2, T3, T4, T5> : IVisitableFactory<T1, T2, T3, T4, T5>
    {
        public IVisitable<T1, T2, T3, T4, T5> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5>(instance);
        public IVisitable<T1, T2, T3, T4, T5> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5>(instance);
        public IVisitable<T1, T2, T3, T4, T5> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5>(instance);
        public IVisitable<T1, T2, T3, T4, T5> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5>(instance);
        public IVisitable<T1, T2, T3, T4, T5> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5>(instance);
    }

    #endregion

    #region T = 6

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6> : IVisitableFactory<T1, T2, T3, T4, T5, T6>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6>(instance);
    }

    #endregion

    #region T = 7

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7>(instance);
    }

    #endregion

    #region T = 8

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(instance);
    }

    #endregion

    #region T = 9

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(instance);
    }

    #endregion

    #region T = 10

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create(T10 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(instance);
    }

    #endregion

    #region T = 11

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T10 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create(T11 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(instance);
    }

    #endregion

    #region T = 12

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T10 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T11 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create(T12 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(instance);
    }

    #endregion

    #region T = 13

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T10 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T11 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T12 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create(T13 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(instance);
    }

    #endregion

    #region T = 14

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T10 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T11 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T12 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T13 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create(T14 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(instance);
    }

    #endregion

    #region T = 15

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T10 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T11 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T12 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T13 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T14 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create(T15 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(instance);
    }

    #endregion

    #region T = 16

    public sealed class VisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IVisitableFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T1 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T2 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T3 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T4 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T5 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T6 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T7 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T8 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T9 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T10 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T11 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T12 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T13 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T14 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T15 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
        public IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create(T16 instance) => new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(instance);
    }

    #endregion

}
