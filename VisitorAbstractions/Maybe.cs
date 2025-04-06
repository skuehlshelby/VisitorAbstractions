using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Abstractions.Functional;
using Abstractions.Visitors.Interfaces;

namespace Abstractions.SumTypes
{
    public abstract class Maybe<T> : IVisitable<T, Nothing>, IEnumerable<T>
    {
        public abstract TReturn Accept<TReturn>(IVisitor<T, Nothing, TReturn> visitor);
        public abstract IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public abstract bool IsSome();
        public abstract bool IsNone();
        public abstract Maybe<R> Bind<R>(Func<T, R> operation);
        public abstract Maybe<R> Bind<R>(Func<Maybe<T>, R> operation);
        private sealed class None : Maybe<T>
        {
            public override TReturn Accept<TReturn>(IVisitor<T, Nothing, TReturn> visitor) => visitor.Visit(Nothing.Instance);

            public override Maybe<R> Bind<R>(Func<T, R> operation) => new Maybe<R>.None();
            public override Maybe<R> Bind<R>(Func<Maybe<T>, R> operation) => new Maybe<R>.None();

            public override IEnumerator<T> GetEnumerator() => Enumerable.Empty<T>().GetEnumerator();
            public override bool IsNone() => true;
            public override bool IsSome() => false;
        }

        private sealed class Some : Maybe<T>
        {
            private readonly T value;

            public Some(T value) => this.value = value;

            public override TReturn Accept<TReturn>(IVisitor<T, Nothing, TReturn> visitor) => visitor.Visit(value);
            public override Maybe<R> Bind<R>(Func<T, R> operation) => new Maybe<R>.Some(operation.Invoke(value));
            public override Maybe<R> Bind<R>(Func<Maybe<T>, R> operation) => new Maybe<R>.None();
            public override IEnumerator<T> GetEnumerator()
            {
                yield return value;
            }
            public override bool IsNone() => false;
            public override bool IsSome() => true;
        }
    }
}
