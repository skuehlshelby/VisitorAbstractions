using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorAbstractions
{
    public static class VisitableFactory<T1, T2>
    {
        private sealed class T1Wrapper : IVisitableExtended<T1, T2>
        {
            private readonly T1 value;

            public T1Wrapper(T1 value)
            {
                this.value = value;
            }

            void IVisitable<T1, T2>.Accept(IVisitor<T1, T2> visitor)
            {
                visitor.Visit(value);
            }

            TReturn IVisitableExtended<T1, T2>.Accept<TReturn>(IVisitorExtended<TReturn, T1, T2> visitor)
            {
                return visitor.Visit(value);
            }
        }

        private sealed class T2Wrapper : IVisitableExtended<T1, T2>
        {
            private readonly T2 value;

            public T2Wrapper(T2 value)
            {
                this.value = value;
            }

            void IVisitable<T1, T2>.Accept(IVisitor<T1, T2> visitor)
            {
                visitor.Visit(value);
            }

            TReturn IVisitableExtended<T1, T2>.Accept<TReturn>(IVisitorExtended<TReturn, T1, T2> visitor)
            {
                return visitor.Visit(value);
            }
        }

        public static IVisitable<T1, T2> Create(T1 instance)
        {
            return new T1Wrapper(instance);
        }

        public static IVisitableExtended<T1, T2> CreateExtended(T1 instance)
        {
            return new T1Wrapper(instance);
        }

        public static IVisitable<T1, T2> Create(T2 instance)
        {
            return new T2Wrapper(instance);
        }

        public static IVisitableExtended<T1, T2> CreateExtended(T2 instance)
        {
            return new T2Wrapper(instance);
        }
    }
}
