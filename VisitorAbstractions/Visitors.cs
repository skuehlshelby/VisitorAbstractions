using System;
using Abstractions.Visitors.Interfaces;
using Abstractions.Functional;

namespace Abstractions.Visitors.FactoryMethods
{
    #region T = 1

    public static class Visitor<T1>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, Nothing>
        {
            private readonly Action<T1> t1Action;

            public NonReturningVisitor(Action<T1> t1Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
        }

        public static IVisitor<T1, Nothing> Create(Action<T1> t1Action) => new NonReturningVisitor(t1Action);
        public static IVisitor<T1, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func) => new ReturningVisitor<TReturn>(t1Func);
    }

    #endregion

    #region T = 2

    public static class Visitor<T1, T2>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action) => new NonReturningVisitor(t1Action, t2Action);
        public static IVisitor<T1, T2, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func) => new ReturningVisitor<TReturn>(t1Func, t2Func);
    }

    #endregion

    #region T = 3

    public static class Visitor<T1, T2, T3>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action) => new NonReturningVisitor(t1Action, t2Action, t3Action);
        public static IVisitor<T1, T2, T3, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func);
    }

    #endregion

    #region T = 4

    public static class Visitor<T1, T2, T3, T4>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action);
        public static IVisitor<T1, T2, T3, T4, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func);
    }

    #endregion

    #region T = 5

    public static class Visitor<T1, T2, T3, T4, T5>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action);
        public static IVisitor<T1, T2, T3, T4, T5, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func);
    }

    #endregion

    #region T = 6

    public static class Visitor<T1, T2, T3, T4, T5, T6>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func);
    }

    #endregion

    #region T = 7

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func);
    }

    #endregion

    #region T = 8

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func);
    }

    #endregion

    #region T = 9

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func);
    }

    #endregion

    #region T = 10

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;
            private readonly Action<T10> t10Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
                this.t10Action = t10Action ?? throw new ArgumentNullException(nameof(t10Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T10 instance)
            {
                t10Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;
            private readonly Func<T10, TReturn> t10Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
                this.t10Func = t10Func ?? throw new ArgumentNullException(nameof(t10Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
            public TReturn Visit(T10 instance) => t10Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action, t10Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func, t10Func);
    }

    #endregion

    #region T = 11

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;
            private readonly Action<T10> t10Action;
            private readonly Action<T11> t11Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
                this.t10Action = t10Action ?? throw new ArgumentNullException(nameof(t10Action));
                this.t11Action = t11Action ?? throw new ArgumentNullException(nameof(t11Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T10 instance)
            {
                t10Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T11 instance)
            {
                t11Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;
            private readonly Func<T10, TReturn> t10Func;
            private readonly Func<T11, TReturn> t11Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
                this.t10Func = t10Func ?? throw new ArgumentNullException(nameof(t10Func));
                this.t11Func = t11Func ?? throw new ArgumentNullException(nameof(t11Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
            public TReturn Visit(T10 instance) => t10Func.Invoke(instance);
            public TReturn Visit(T11 instance) => t11Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action, t10Action, t11Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func, t10Func, t11Func);
    }

    #endregion

    #region T = 12

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;
            private readonly Action<T10> t10Action;
            private readonly Action<T11> t11Action;
            private readonly Action<T12> t12Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
                this.t10Action = t10Action ?? throw new ArgumentNullException(nameof(t10Action));
                this.t11Action = t11Action ?? throw new ArgumentNullException(nameof(t11Action));
                this.t12Action = t12Action ?? throw new ArgumentNullException(nameof(t12Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T10 instance)
            {
                t10Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T11 instance)
            {
                t11Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T12 instance)
            {
                t12Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;
            private readonly Func<T10, TReturn> t10Func;
            private readonly Func<T11, TReturn> t11Func;
            private readonly Func<T12, TReturn> t12Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
                this.t10Func = t10Func ?? throw new ArgumentNullException(nameof(t10Func));
                this.t11Func = t11Func ?? throw new ArgumentNullException(nameof(t11Func));
                this.t12Func = t12Func ?? throw new ArgumentNullException(nameof(t12Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
            public TReturn Visit(T10 instance) => t10Func.Invoke(instance);
            public TReturn Visit(T11 instance) => t11Func.Invoke(instance);
            public TReturn Visit(T12 instance) => t12Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action, t10Action, t11Action, t12Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func, t10Func, t11Func, t12Func);
    }

    #endregion

    #region T = 13

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;
            private readonly Action<T10> t10Action;
            private readonly Action<T11> t11Action;
            private readonly Action<T12> t12Action;
            private readonly Action<T13> t13Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
                this.t10Action = t10Action ?? throw new ArgumentNullException(nameof(t10Action));
                this.t11Action = t11Action ?? throw new ArgumentNullException(nameof(t11Action));
                this.t12Action = t12Action ?? throw new ArgumentNullException(nameof(t12Action));
                this.t13Action = t13Action ?? throw new ArgumentNullException(nameof(t13Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T10 instance)
            {
                t10Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T11 instance)
            {
                t11Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T12 instance)
            {
                t12Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T13 instance)
            {
                t13Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;
            private readonly Func<T10, TReturn> t10Func;
            private readonly Func<T11, TReturn> t11Func;
            private readonly Func<T12, TReturn> t12Func;
            private readonly Func<T13, TReturn> t13Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
                this.t10Func = t10Func ?? throw new ArgumentNullException(nameof(t10Func));
                this.t11Func = t11Func ?? throw new ArgumentNullException(nameof(t11Func));
                this.t12Func = t12Func ?? throw new ArgumentNullException(nameof(t12Func));
                this.t13Func = t13Func ?? throw new ArgumentNullException(nameof(t13Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
            public TReturn Visit(T10 instance) => t10Func.Invoke(instance);
            public TReturn Visit(T11 instance) => t11Func.Invoke(instance);
            public TReturn Visit(T12 instance) => t12Func.Invoke(instance);
            public TReturn Visit(T13 instance) => t13Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action, t10Action, t11Action, t12Action, t13Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func, t10Func, t11Func, t12Func, t13Func);
    }

    #endregion

    #region T = 14

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;
            private readonly Action<T10> t10Action;
            private readonly Action<T11> t11Action;
            private readonly Action<T12> t12Action;
            private readonly Action<T13> t13Action;
            private readonly Action<T14> t14Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
                this.t10Action = t10Action ?? throw new ArgumentNullException(nameof(t10Action));
                this.t11Action = t11Action ?? throw new ArgumentNullException(nameof(t11Action));
                this.t12Action = t12Action ?? throw new ArgumentNullException(nameof(t12Action));
                this.t13Action = t13Action ?? throw new ArgumentNullException(nameof(t13Action));
                this.t14Action = t14Action ?? throw new ArgumentNullException(nameof(t14Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T10 instance)
            {
                t10Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T11 instance)
            {
                t11Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T12 instance)
            {
                t12Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T13 instance)
            {
                t13Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T14 instance)
            {
                t14Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;
            private readonly Func<T10, TReturn> t10Func;
            private readonly Func<T11, TReturn> t11Func;
            private readonly Func<T12, TReturn> t12Func;
            private readonly Func<T13, TReturn> t13Func;
            private readonly Func<T14, TReturn> t14Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func, Func<T14, TReturn> t14Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
                this.t10Func = t10Func ?? throw new ArgumentNullException(nameof(t10Func));
                this.t11Func = t11Func ?? throw new ArgumentNullException(nameof(t11Func));
                this.t12Func = t12Func ?? throw new ArgumentNullException(nameof(t12Func));
                this.t13Func = t13Func ?? throw new ArgumentNullException(nameof(t13Func));
                this.t14Func = t14Func ?? throw new ArgumentNullException(nameof(t14Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
            public TReturn Visit(T10 instance) => t10Func.Invoke(instance);
            public TReturn Visit(T11 instance) => t11Func.Invoke(instance);
            public TReturn Visit(T12 instance) => t12Func.Invoke(instance);
            public TReturn Visit(T13 instance) => t13Func.Invoke(instance);
            public TReturn Visit(T14 instance) => t14Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action, t10Action, t11Action, t12Action, t13Action, t14Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func, Func<T14, TReturn> t14Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func, t10Func, t11Func, t12Func, t13Func, t14Func);
    }

    #endregion

    #region T = 15

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;
            private readonly Action<T10> t10Action;
            private readonly Action<T11> t11Action;
            private readonly Action<T12> t12Action;
            private readonly Action<T13> t13Action;
            private readonly Action<T14> t14Action;
            private readonly Action<T15> t15Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action, Action<T15> t15Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
                this.t10Action = t10Action ?? throw new ArgumentNullException(nameof(t10Action));
                this.t11Action = t11Action ?? throw new ArgumentNullException(nameof(t11Action));
                this.t12Action = t12Action ?? throw new ArgumentNullException(nameof(t12Action));
                this.t13Action = t13Action ?? throw new ArgumentNullException(nameof(t13Action));
                this.t14Action = t14Action ?? throw new ArgumentNullException(nameof(t14Action));
                this.t15Action = t15Action ?? throw new ArgumentNullException(nameof(t15Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T10 instance)
            {
                t10Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T11 instance)
            {
                t11Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T12 instance)
            {
                t12Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T13 instance)
            {
                t13Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T14 instance)
            {
                t14Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T15 instance)
            {
                t15Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;
            private readonly Func<T10, TReturn> t10Func;
            private readonly Func<T11, TReturn> t11Func;
            private readonly Func<T12, TReturn> t12Func;
            private readonly Func<T13, TReturn> t13Func;
            private readonly Func<T14, TReturn> t14Func;
            private readonly Func<T15, TReturn> t15Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func, Func<T14, TReturn> t14Func, Func<T15, TReturn> t15Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
                this.t10Func = t10Func ?? throw new ArgumentNullException(nameof(t10Func));
                this.t11Func = t11Func ?? throw new ArgumentNullException(nameof(t11Func));
                this.t12Func = t12Func ?? throw new ArgumentNullException(nameof(t12Func));
                this.t13Func = t13Func ?? throw new ArgumentNullException(nameof(t13Func));
                this.t14Func = t14Func ?? throw new ArgumentNullException(nameof(t14Func));
                this.t15Func = t15Func ?? throw new ArgumentNullException(nameof(t15Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
            public TReturn Visit(T10 instance) => t10Func.Invoke(instance);
            public TReturn Visit(T11 instance) => t11Func.Invoke(instance);
            public TReturn Visit(T12 instance) => t12Func.Invoke(instance);
            public TReturn Visit(T13 instance) => t13Func.Invoke(instance);
            public TReturn Visit(T14 instance) => t14Func.Invoke(instance);
            public TReturn Visit(T15 instance) => t15Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action, Action<T15> t15Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action, t10Action, t11Action, t12Action, t13Action, t14Action, t15Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func, Func<T14, TReturn> t14Func, Func<T15, TReturn> t15Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func, t10Func, t11Func, t12Func, t13Func, t14Func, t15Func);
    }

    #endregion

    #region T = 16

    public static class Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        private sealed class NonReturningVisitor : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Nothing>
        {
            private readonly Action<T1> t1Action;
            private readonly Action<T2> t2Action;
            private readonly Action<T3> t3Action;
            private readonly Action<T4> t4Action;
            private readonly Action<T5> t5Action;
            private readonly Action<T6> t6Action;
            private readonly Action<T7> t7Action;
            private readonly Action<T8> t8Action;
            private readonly Action<T9> t9Action;
            private readonly Action<T10> t10Action;
            private readonly Action<T11> t11Action;
            private readonly Action<T12> t12Action;
            private readonly Action<T13> t13Action;
            private readonly Action<T14> t14Action;
            private readonly Action<T15> t15Action;
            private readonly Action<T16> t16Action;

            public NonReturningVisitor(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action, Action<T15> t15Action, Action<T16> t16Action)
            {
                this.t1Action = t1Action ?? throw new ArgumentNullException(nameof(t1Action));
                this.t2Action = t2Action ?? throw new ArgumentNullException(nameof(t2Action));
                this.t3Action = t3Action ?? throw new ArgumentNullException(nameof(t3Action));
                this.t4Action = t4Action ?? throw new ArgumentNullException(nameof(t4Action));
                this.t5Action = t5Action ?? throw new ArgumentNullException(nameof(t5Action));
                this.t6Action = t6Action ?? throw new ArgumentNullException(nameof(t6Action));
                this.t7Action = t7Action ?? throw new ArgumentNullException(nameof(t7Action));
                this.t8Action = t8Action ?? throw new ArgumentNullException(nameof(t8Action));
                this.t9Action = t9Action ?? throw new ArgumentNullException(nameof(t9Action));
                this.t10Action = t10Action ?? throw new ArgumentNullException(nameof(t10Action));
                this.t11Action = t11Action ?? throw new ArgumentNullException(nameof(t11Action));
                this.t12Action = t12Action ?? throw new ArgumentNullException(nameof(t12Action));
                this.t13Action = t13Action ?? throw new ArgumentNullException(nameof(t13Action));
                this.t14Action = t14Action ?? throw new ArgumentNullException(nameof(t14Action));
                this.t15Action = t15Action ?? throw new ArgumentNullException(nameof(t15Action));
                this.t16Action = t16Action ?? throw new ArgumentNullException(nameof(t16Action));
            }

            public Nothing Visit(T1 instance)
            {
                t1Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T2 instance)
            {
                t2Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T3 instance)
            {
                t3Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T4 instance)
            {
                t4Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T5 instance)
            {
                t5Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T6 instance)
            {
                t6Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T7 instance)
            {
                t7Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T8 instance)
            {
                t8Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T9 instance)
            {
                t9Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T10 instance)
            {
                t10Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T11 instance)
            {
                t11Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T12 instance)
            {
                t12Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T13 instance)
            {
                t13Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T14 instance)
            {
                t14Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T15 instance)
            {
                t15Action.Invoke(instance);
                return Nothing.Instance;
            }

            public Nothing Visit(T16 instance)
            {
                t16Action.Invoke(instance);
                return Nothing.Instance;
            }
        }

        private sealed class ReturningVisitor<TReturn> : IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn>
        {
            private readonly Func<T1, TReturn> t1Func;
            private readonly Func<T2, TReturn> t2Func;
            private readonly Func<T3, TReturn> t3Func;
            private readonly Func<T4, TReturn> t4Func;
            private readonly Func<T5, TReturn> t5Func;
            private readonly Func<T6, TReturn> t6Func;
            private readonly Func<T7, TReturn> t7Func;
            private readonly Func<T8, TReturn> t8Func;
            private readonly Func<T9, TReturn> t9Func;
            private readonly Func<T10, TReturn> t10Func;
            private readonly Func<T11, TReturn> t11Func;
            private readonly Func<T12, TReturn> t12Func;
            private readonly Func<T13, TReturn> t13Func;
            private readonly Func<T14, TReturn> t14Func;
            private readonly Func<T15, TReturn> t15Func;
            private readonly Func<T16, TReturn> t16Func;

            public ReturningVisitor(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func, Func<T14, TReturn> t14Func, Func<T15, TReturn> t15Func, Func<T16, TReturn> t16Func)
            {
                this.t1Func = t1Func ?? throw new ArgumentNullException(nameof(t1Func));
                this.t2Func = t2Func ?? throw new ArgumentNullException(nameof(t2Func));
                this.t3Func = t3Func ?? throw new ArgumentNullException(nameof(t3Func));
                this.t4Func = t4Func ?? throw new ArgumentNullException(nameof(t4Func));
                this.t5Func = t5Func ?? throw new ArgumentNullException(nameof(t5Func));
                this.t6Func = t6Func ?? throw new ArgumentNullException(nameof(t6Func));
                this.t7Func = t7Func ?? throw new ArgumentNullException(nameof(t7Func));
                this.t8Func = t8Func ?? throw new ArgumentNullException(nameof(t8Func));
                this.t9Func = t9Func ?? throw new ArgumentNullException(nameof(t9Func));
                this.t10Func = t10Func ?? throw new ArgumentNullException(nameof(t10Func));
                this.t11Func = t11Func ?? throw new ArgumentNullException(nameof(t11Func));
                this.t12Func = t12Func ?? throw new ArgumentNullException(nameof(t12Func));
                this.t13Func = t13Func ?? throw new ArgumentNullException(nameof(t13Func));
                this.t14Func = t14Func ?? throw new ArgumentNullException(nameof(t14Func));
                this.t15Func = t15Func ?? throw new ArgumentNullException(nameof(t15Func));
                this.t16Func = t16Func ?? throw new ArgumentNullException(nameof(t16Func));
            }

            public TReturn Visit(T1 instance) => t1Func.Invoke(instance);
            public TReturn Visit(T2 instance) => t2Func.Invoke(instance);
            public TReturn Visit(T3 instance) => t3Func.Invoke(instance);
            public TReturn Visit(T4 instance) => t4Func.Invoke(instance);
            public TReturn Visit(T5 instance) => t5Func.Invoke(instance);
            public TReturn Visit(T6 instance) => t6Func.Invoke(instance);
            public TReturn Visit(T7 instance) => t7Func.Invoke(instance);
            public TReturn Visit(T8 instance) => t8Func.Invoke(instance);
            public TReturn Visit(T9 instance) => t9Func.Invoke(instance);
            public TReturn Visit(T10 instance) => t10Func.Invoke(instance);
            public TReturn Visit(T11 instance) => t11Func.Invoke(instance);
            public TReturn Visit(T12 instance) => t12Func.Invoke(instance);
            public TReturn Visit(T13 instance) => t13Func.Invoke(instance);
            public TReturn Visit(T14 instance) => t14Func.Invoke(instance);
            public TReturn Visit(T15 instance) => t15Func.Invoke(instance);
            public TReturn Visit(T16 instance) => t16Func.Invoke(instance);
        }

        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Nothing> Create(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action, Action<T15> t15Action, Action<T16> t16Action) => new NonReturningVisitor(t1Action, t2Action, t3Action, t4Action, t5Action, t6Action, t7Action, t8Action, t9Action, t10Action, t11Action, t12Action, t13Action, t14Action, t15Action, t16Action);
        public static IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> Create<TReturn>(Func<T1, TReturn> t1Func, Func<T2, TReturn> t2Func, Func<T3, TReturn> t3Func, Func<T4, TReturn> t4Func, Func<T5, TReturn> t5Func, Func<T6, TReturn> t6Func, Func<T7, TReturn> t7Func, Func<T8, TReturn> t8Func, Func<T9, TReturn> t9Func, Func<T10, TReturn> t10Func, Func<T11, TReturn> t11Func, Func<T12, TReturn> t12Func, Func<T13, TReturn> t13Func, Func<T14, TReturn> t14Func, Func<T15, TReturn> t15Func, Func<T16, TReturn> t16Func) => new ReturningVisitor<TReturn>(t1Func, t2Func, t3Func, t4Func, t5Func, t6Func, t7Func, t8Func, t9Func, t10Func, t11Func, t12Func, t13Func, t14Func, t15Func, t16Func);
    }

    #endregion

}
