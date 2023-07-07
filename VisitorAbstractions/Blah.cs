using System;

namespace Scott.Abstractions.VisitorPattern
{
    public interface IVisitable<out T1, out T2>
    {
        void Accept(IActionVisitor<T1, T2> visitor);
        TOut Accept<TOut>(IFunctionVisitor<TOut, T1, T2> visitor);
    }

    public interface IActionVisitor<in T1, in T2>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
    }

    public interface IFunctionVisitor<TOut, in T1, in T2>
    {
        TOut Visit(T1 instance);
        TOut Visit(T2 instance);
    }

    public interface IActionVisitor2x2<T1, T2, T3, T4>
    {
        void Visit(T1 left, T3 right);
        void Visit(T1 left, T4 right);
        void Visit(T2 left, T3 right);
        void Visit(T2 left, T4 right);
    }

    public interface IFunctionVisitor2x2<TOut, T1, T2, T3, T4>
    {
        TOut Visit(T1 left, T3 right);
        TOut Visit(T1 left, T4 right);
        TOut Visit(T2 left, T3 right);
        TOut Visit(T2 left, T4 right);
    }

    public static class Visitable<T1, T2>
    {
        private sealed class T1Wrapper : IVisitable<T1, T2>
        {
            private readonly T1 instance;
            public T1Wrapper(T1 instance) => this.instance = instance;
            void IVisitable<T1, T2>.Accept(IActionVisitor<T1, T2> visitor) => visitor.Visit(instance);
            TOut IVisitable<T1, T2>.Accept<TOut>(IFunctionVisitor<TOut, T1, T2> visitor) => visitor.Visit(instance);
        }

        private sealed class T2Wrapper : IVisitable<T1, T2>
        {
            private readonly T2 instance;
            public T2Wrapper(T2 instance) => this.instance = instance;
            void IVisitable<T1, T2>.Accept(IActionVisitor<T1, T2> visitor) => visitor.Visit(instance);
            TOut IVisitable<T1, T2>.Accept<TOut>(IFunctionVisitor<TOut, T1, T2> visitor) => visitor.Visit(instance);
        }

        public static IVisitable<T1, T2> Create(T1 instance) => new T1Wrapper(instance);
        public static IVisitable<T1, T2> Create(T2 instance) => new T2Wrapper(instance);
    }

    public static class Visitor<T1, T2>
    {
        private sealed class ActionVisitor : IActionVisitor<T1, T2>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;

            public ActionVisitor(Action<T1> t1Action, Action<T2> t2Action)
            {
                this.t1Action = t1Action;
                this.t2Action = t2Action;
            }

            void IActionVisitor<T1, T2>.Visit(T1 instance) => t1Action.Invoke(instance);
            void IActionVisitor<T1, T2>.Visit(T2 instance) => t2Action.Invoke(instance);
        }

        private sealed class FunctionVisitor<TOut> : IFunctionVisitor<TOut, T1, T2>
        {
            private readonly Func<T1, TOut> t1Action;
            private readonly Func<T2, TOut> t2Action;

            public FunctionVisitor(Func<T1, TOut> t1Action, Func<T2, TOut> t2Action)
            {
                this.t1Action = t1Action;
                this.t2Action = t2Action;
            }

            TOut IFunctionVisitor<TOut, T1, T2>.Visit(T1 instance) => t1Action.Invoke(instance);
            TOut IFunctionVisitor<TOut, T1, T2>.Visit(T2 instance) => t2Action.Invoke(instance);
        }

        public static IActionVisitor<T1, T2> Create(Action<T1> t1, Action<T2> t2) => new ActionVisitor(t1, t2);

        public static IFunctionVisitor<TOut, T1, T2> Create<TOut>(Func<T1, TOut> t1, Func<T2, TOut> t2) => new FunctionVisitor<TOut>(t1, t2);
    }


    public static class Visitor<T1, T2, T3>
    {
        private sealed class ActionVisitor : IActionVisitor<T1, T2, T3>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;

            public ActionVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action)
            {
                this.t1Action = t1Action;
                this.t2Action = t2Action;
                this.t3Action = t3Action;
            }

            void IActionVisitor<T1, T2, T3>.Visit(T1 instance) => t1Action.Invoke(instance);
            void IActionVisitor<T1, T2, T3>.Visit(T2 instance) => t2Action.Invoke(instance);
            void IActionVisitor<T1, T2, T3>.Visit(T3 instance) => t3Action.Invoke(instance);
        }

        private sealed class FunctionVisitor<TOut> : IFunctionVisitor<TOut, T1, T2, T3>
        {
            private readonly Func<T1, TOut> t1Action;
            private readonly Func<T2, TOut> t2Action;
            private readonly Func<T3, TOut> t3Action;

            public FunctionVisitor(Func<T1, TOut> t1Action, Func<T2, TOut> t2Action, Func<T3, TOut> t3Action)
            {
                this.t1Action = t1Action;
                this.t2Action = t2Action;
                this.t3Action = t3Action;
            }

            TOut IFunctionVisitor<TOut, T1, T2, T3>.Visit(T1 instance) => t1Action.Invoke(instance);
            TOut IFunctionVisitor<TOut, T1, T2, T3>.Visit(T2 instance) => t2Action.Invoke(instance);
            TOut IFunctionVisitor<TOut, T1, T2, T3>.Visit(T3 instance) => t3Action.Invoke(instance);
        }

        public static IActionVisitor<T1, T2, T3> Create(Action<T1> t1, Action<T2> t2, Action<T3> t3) => new ActionVisitor(t1, t2, t3);

        public static IFunctionVisitor<TOut, T1, T2, T3> Create<TOut>(Func<T1, TOut> t1, Func<T2, TOut> t2, Func<T3, TOut> t3) => new FunctionVisitor<TOut>(t1, t2, t3);
    }

    //////////////////////////////////////////////

    public interface IVisitable<out T1, out T2, out T3>
    {
        void Accept(IActionVisitor<T1, T2, T3> visitor);
        TOut Accept<TOut>(IFunctionVisitor<TOut, T1, T2, T3> visitor);
    }

    public interface IActionVisitor<in T1, in T2, in T3>
    {
        void Visit(T1 instance);
        void Visit(T2 instance);
        void Visit(T3 instance);
    }

    public interface IFunctionVisitor<TOut, in T1, in T2, in T3>
    {
        TOut Visit(T1 instance);
        TOut Visit(T2 instance);
        TOut Visit(T3 instance);
    }

    public interface IActionVisitor2x3<T1, T2, T3, T4, T5>
    {
        void Visit(T1 left, T3 right);
        void Visit(T1 left, T4 right);
        void Visit(T1 left, T5 right);
        void Visit(T2 left, T3 right);
        void Visit(T2 left, T4 right);
        void Visit(T2 left, T5 right);
    }

    public interface IActionVisitor3x2<in T1, in T2, in T3, in T4, in T5>
    {
        void Visit(T1 left, T4 right);
        void Visit(T1 left, T5 right);
        void Visit(T2 left, T4 right);
        void Visit(T2 left, T5 right);
        void Visit(T3 left, T4 right);
        void Visit(T3 left, T5 right);
    }

    public interface IActionVisitor3x3<in T1, in T2, in T3, in T4, in T5, in T6>
    {
        void Visit(T1 left, T4 right);
        void Visit(T1 left, T5 right);
        void Visit(T1 left, T6 right);
        void Visit(T2 left, T4 right);
        void Visit(T2 left, T5 right);
        void Visit(T2 left, T6 right);
        void Visit(T3 left, T4 right);
        void Visit(T3 left, T5 right);
        void Visit(T3 left, T6 right);
    }

    public static class Visitors
    {
        public static void Visit<T1, T2, T3, T4>(IActionVisitor2x2<T1, T2, T3, T4> visitor, IVisitable<T1, T2> left, IVisitable<T3, T4> right)
        {
            left.Accept(Visitor<T1, T2>
                .Create(t1 => right
                    .Accept(Visitor<T3, T4>
                        .Create(t3 => visitor.Visit(t1, t3),
                                t4 => visitor.Visit(t1, t4))),
                        t2 => right
                    .Accept(Visitor<T3, T4>
                        .Create(t3 => visitor.Visit(t2, t3),
                                t4 => visitor.Visit(t2, t4)))));
        }

        public static TOut Visit<TOut, T1, T2, T3, T4>(IFunctionVisitor2x2<TOut, T1, T2, T3, T4> visitor, IVisitable<T1, T2> left, IVisitable<T3, T4> right)
        {
            return left.Accept(Visitor<T1, T2>
                .Create(t1 => right
                    .Accept(Visitor<T3, T4>
                        .Create(t3 => visitor.Visit(t1, t3),
                                t4 => visitor.Visit(t1, t4))),
                        t2 => right
                    .Accept(Visitor<T3, T4>
                        .Create(t3 => visitor.Visit(t2, t3),
                                t4 => visitor.Visit(t2, t4)))));
        }

        public static void Visit<T1, T2, T3, T4, T5>(IActionVisitor3x2<T1, T2, T3, T4, T5> visitor, IVisitable<T1, T2, T3> left, IVisitable<T4, T5> right)
        {
            left.Accept(Visitor<T1, T2, T3>
                .Create(inner => right
                    .Accept(Visitor<T4, T5>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer))),
                        inner => right
                    .Accept(Visitor<T4, T5>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer))),
                        inner => right
                    .Accept(Visitor<T4, T5>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer)))));
        }

        public static void Visit<T1, T2, T3, T4, T5, T6>(IActionVisitor2x3<T1, T2, T3, T4, T5> visitor, IVisitable<T1, T2> left, IVisitable<T3, T4, T5> right)
        {
            left.Accept(Visitor<T1, T2>
                .Create(inner => right
                    .Accept(Visitor<T3, T4, T5>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer))),
                        inner => right
                    .Accept(Visitor<T3, T4, T5>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer)))));
        }

        public static void Visit<T1, T2, T3, T4, T5, T6>(IActionVisitor3x3<T1, T2, T3, T4, T5, T6> visitor, IVisitable<T1, T2, T3> left, IVisitable<T4, T5, T6> right)
        {
            left.Accept(Visitor<T1, T2, T3>
                .Create(inner => right
                    .Accept(Visitor<T4, T5, T6>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer))),
                        inner => right
                    .Accept(Visitor<T4, T5, T6>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer))),
                        inner => right
                    .Accept(Visitor<T4, T5, T6>
                        .Create(outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer),
                                outer => visitor.Visit(inner, outer)))));
        }

        public static void DoNothing<T>(T _)
        {
        }
    }
}
