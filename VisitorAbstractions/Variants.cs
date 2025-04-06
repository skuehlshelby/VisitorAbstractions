using System.Linq;
using System.Diagnostics;
using Abstractions.Visitors.Interfaces;
using Abstractions.Visitors.FactoryMethods;

namespace Abstractions.SumTypes.Variants
{
    #region T = 1
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1> : IVisitable<T1>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1>.Create(t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, TReturn> visitor) => visitor.Visit(t1);
        }

        private readonly IVisitable<T1> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1>(T1 instance) => new(instance);
    }

    #endregion
    
    #region T = 2
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2> : IVisitable<T1, T2>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2>.Create(t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, TReturn> visitor) => visitor.Visit(t2);
        }

        private readonly IVisitable<T1, T2> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2>(T2 instance) => new(instance);
    }

    #endregion
    
    #region T = 3
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3> : IVisitable<T1, T2, T3>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, TReturn> visitor) => visitor.Visit(t3);
        }

        private readonly IVisitable<T1, T2, T3> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3>(T3 instance) => new(instance);
    }

    #endregion
    
    #region T = 4
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4> : IVisitable<T1, T2, T3, T4>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, TReturn> visitor) => visitor.Visit(t4);
        }

        private readonly IVisitable<T1, T2, T3, T4> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4>(T4 instance) => new(instance);
    }

    #endregion
    
    #region T = 5
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5> : IVisitable<T1, T2, T3, T4, T5>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, TReturn> visitor) => visitor.Visit(t5);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T5 instance) => new(instance);
    }

    #endregion
    
    #region T = 6
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6> : IVisitable<T1, T2, T3, T4, T5, T6>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor) => visitor.Visit(t6);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T6 instance) => new(instance);
    }

    #endregion
    
    #region T = 7
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7> : IVisitable<T1, T2, T3, T4, T5, T6, T7>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => visitor.Visit(t7);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T7 instance) => new(instance);
    }

    #endregion
    
    #region T = 8
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => visitor.Visit(t8);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T8 instance) => new(instance);
    }

    #endregion
    
    #region T = 9
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => visitor.Visit(t9);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 instance) => new(instance);
    }

    #endregion
    
    #region T = 10
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t9);
        }

        private sealed class T10Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        {
            private readonly T10 t10;
            public T10Visitable(T10 t10) => this.t10 = t10;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => visitor.Visit(t10);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public Variant(T10 instance) => inner = new T10Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 instance) => new(instance);
    }

    #endregion
    
    #region T = 11
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t9);
        }

        private sealed class T10Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T10 t10;
            public T10Visitable(T10 t10) => this.t10 = t10;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t10);
        }

        private sealed class T11Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        {
            private readonly T11 t11;
            public T11Visitable(T11 t11) => this.t11 = t11;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => visitor.Visit(t11);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public Variant(T10 instance) => inner = new T10Visitable(instance);
        public Variant(T11 instance) => inner = new T11Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 instance) => new(instance);
    }

    #endregion
    
    #region T = 12
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t9);
        }

        private sealed class T10Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T10 t10;
            public T10Visitable(T10 t10) => this.t10 = t10;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t10);
        }

        private sealed class T11Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T11 t11;
            public T11Visitable(T11 t11) => this.t11 = t11;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t11);
        }

        private sealed class T12Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        {
            private readonly T12 t12;
            public T12Visitable(T12 t12) => this.t12 = t12;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => visitor.Visit(t12);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public Variant(T10 instance) => inner = new T10Visitable(instance);
        public Variant(T11 instance) => inner = new T11Visitable(instance);
        public Variant(T12 instance) => inner = new T12Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 instance) => new(instance);
    }

    #endregion
    
    #region T = 13
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t9);
        }

        private sealed class T10Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T10 t10;
            public T10Visitable(T10 t10) => this.t10 = t10;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t10);
        }

        private sealed class T11Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T11 t11;
            public T11Visitable(T11 t11) => this.t11 = t11;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t11);
        }

        private sealed class T12Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T12 t12;
            public T12Visitable(T12 t12) => this.t12 = t12;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t12);
        }

        private sealed class T13Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        {
            private readonly T13 t13;
            public T13Visitable(T13 t13) => this.t13 = t13;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => visitor.Visit(t13);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public Variant(T10 instance) => inner = new T10Visitable(instance);
        public Variant(T11 instance) => inner = new T11Visitable(instance);
        public Variant(T12 instance) => inner = new T12Visitable(instance);
        public Variant(T13 instance) => inner = new T13Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 instance) => new(instance);
    }

    #endregion
    
    #region T = 14
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t9);
        }

        private sealed class T10Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T10 t10;
            public T10Visitable(T10 t10) => this.t10 = t10;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t10);
        }

        private sealed class T11Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T11 t11;
            public T11Visitable(T11 t11) => this.t11 = t11;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t11);
        }

        private sealed class T12Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T12 t12;
            public T12Visitable(T12 t12) => this.t12 = t12;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t12);
        }

        private sealed class T13Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T13 t13;
            public T13Visitable(T13 t13) => this.t13 = t13;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t13);
        }

        private sealed class T14Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        {
            private readonly T14 t14;
            public T14Visitable(T14 t14) => this.t14 = t14;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => visitor.Visit(t14);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public Variant(T10 instance) => inner = new T10Visitable(instance);
        public Variant(T11 instance) => inner = new T11Visitable(instance);
        public Variant(T12 instance) => inner = new T12Visitable(instance);
        public Variant(T13 instance) => inner = new T13Visitable(instance);
        public Variant(T14 instance) => inner = new T14Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 instance) => new(instance);
    }

    #endregion
    
    #region T = 15
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t9);
        }

        private sealed class T10Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T10 t10;
            public T10Visitable(T10 t10) => this.t10 = t10;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t10);
        }

        private sealed class T11Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T11 t11;
            public T11Visitable(T11 t11) => this.t11 = t11;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t11);
        }

        private sealed class T12Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T12 t12;
            public T12Visitable(T12 t12) => this.t12 = t12;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t12);
        }

        private sealed class T13Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T13 t13;
            public T13Visitable(T13 t13) => this.t13 = t13;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t13);
        }

        private sealed class T14Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T14 t14;
            public T14Visitable(T14 t14) => this.t14 = t14;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t14);
        }

        private sealed class T15Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        {
            private readonly T15 t15;
            public T15Visitable(T15 t15) => this.t15 = t15;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => visitor.Visit(t15);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public Variant(T10 instance) => inner = new T10Visitable(instance);
        public Variant(T11 instance) => inner = new T11Visitable(instance);
        public Variant(T12 instance) => inner = new T12Visitable(instance);
        public Variant(T13 instance) => inner = new T13Visitable(instance);
        public Variant(T14 instance) => inner = new T14Visitable(instance);
        public Variant(T15 instance) => inner = new T15Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 instance) => new(instance);
    }

    #endregion
    
    #region T = 16
    
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        private string GetDebuggerDisplay() => $"{nameof(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>)}<{string.Join(", ", GetType().GetGenericArguments().Select(arg => arg.Name))}> : {Accept(Visitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Create(t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name, t => t?.GetType().Name))}";
        private sealed class T1Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T1 t1;
            public T1Visitable(T1 t1) => this.t1 = t1;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t1);
        }

        private sealed class T2Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T2 t2;
            public T2Visitable(T2 t2) => this.t2 = t2;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t2);
        }

        private sealed class T3Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T3 t3;
            public T3Visitable(T3 t3) => this.t3 = t3;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t3);
        }

        private sealed class T4Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T4 t4;
            public T4Visitable(T4 t4) => this.t4 = t4;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t4);
        }

        private sealed class T5Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T5 t5;
            public T5Visitable(T5 t5) => this.t5 = t5;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t5);
        }

        private sealed class T6Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T6 t6;
            public T6Visitable(T6 t6) => this.t6 = t6;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t6);
        }

        private sealed class T7Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T7 t7;
            public T7Visitable(T7 t7) => this.t7 = t7;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t7);
        }

        private sealed class T8Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T8 t8;
            public T8Visitable(T8 t8) => this.t8 = t8;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t8);
        }

        private sealed class T9Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T9 t9;
            public T9Visitable(T9 t9) => this.t9 = t9;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t9);
        }

        private sealed class T10Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T10 t10;
            public T10Visitable(T10 t10) => this.t10 = t10;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t10);
        }

        private sealed class T11Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T11 t11;
            public T11Visitable(T11 t11) => this.t11 = t11;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t11);
        }

        private sealed class T12Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T12 t12;
            public T12Visitable(T12 t12) => this.t12 = t12;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t12);
        }

        private sealed class T13Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T13 t13;
            public T13Visitable(T13 t13) => this.t13 = t13;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t13);
        }

        private sealed class T14Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T14 t14;
            public T14Visitable(T14 t14) => this.t14 = t14;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t14);
        }

        private sealed class T15Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T15 t15;
            public T15Visitable(T15 t15) => this.t15 = t15;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t15);
        }

        private sealed class T16Visitable : IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        {
            private readonly T16 t16;
            public T16Visitable(T16 t16) => this.t16 = t16;
            public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => visitor.Visit(t16);
        }

        private readonly IVisitable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> inner;
        public Variant(T1 instance) => inner = new T1Visitable(instance);
        public Variant(T2 instance) => inner = new T2Visitable(instance);
        public Variant(T3 instance) => inner = new T3Visitable(instance);
        public Variant(T4 instance) => inner = new T4Visitable(instance);
        public Variant(T5 instance) => inner = new T5Visitable(instance);
        public Variant(T6 instance) => inner = new T6Visitable(instance);
        public Variant(T7 instance) => inner = new T7Visitable(instance);
        public Variant(T8 instance) => inner = new T8Visitable(instance);
        public Variant(T9 instance) => inner = new T9Visitable(instance);
        public Variant(T10 instance) => inner = new T10Visitable(instance);
        public Variant(T11 instance) => inner = new T11Visitable(instance);
        public Variant(T12 instance) => inner = new T12Visitable(instance);
        public Variant(T13 instance) => inner = new T13Visitable(instance);
        public Variant(T14 instance) => inner = new T14Visitable(instance);
        public Variant(T15 instance) => inner = new T15Visitable(instance);
        public Variant(T16 instance) => inner = new T16Visitable(instance);
        public TReturn Accept<TReturn>(IVisitor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TReturn> visitor) => inner.Accept(visitor);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T2 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T3 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T4 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T5 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T6 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T7 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T8 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T9 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T10 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T11 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T12 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T13 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T14 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T15 instance) => new(instance);
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T16 instance) => new(instance);
    }

    #endregion
    
}
