using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorAbstractions
{
    public static class Visitor<T1, T2>
    {
        private sealed class SimpleVisitor : IVisitor<T1, T2>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;

            public SimpleVisitor(Action<T1> t1Action, Action<T2> t2Action)
            {
                this.t1Action = t1Action;
                this.t2Action = t2Action;
            }

            void IVisitor<T1, T2>.Visit(T1 instance)
            {
                t1Action.Invoke(instance);
            }

            void IVisitor<T1, T2>.Visit(T2 instance)
            {
                t2Action.Invoke(instance);
            }
        }

        public static IVisitor<T1, T2> Create(Action<T1> t1, Action<T2> t2)
        {
            return new SimpleVisitor(t1, t2);
        }

        private sealed class ExtendedVisitor<TReturn> : IVisitorExtended<TReturn, T1, T2>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;

            public ExtendedVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func)
            {
                this.t1Func = t1Func;
                this.t2Func = t2Func;
            }

            TReturn IVisitorExtended<TReturn, T1, T2>.Visit(T1 instance)
            {
                return t1Func.Invoke(instance);
            }

            TReturn IVisitorExtended<TReturn, T1, T2>.Visit(T2 instance)
            {
                return t2Func.Invoke(instance);
            }
        }

        public static IVisitorExtended<TReturn, T1, T2> Create<TReturn>(Func<T1, TReturn> t1, Func<T2, TReturn> t2)
        {
            return new ExtendedVisitor<TReturn>(t1, t2);
        }
    }
}
