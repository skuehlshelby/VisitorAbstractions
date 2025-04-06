using Abstractions.Functional;
using Abstractions.Visitors.Extensions;
using Abstractions.Visitors.FactoryMethods;
using Abstractions.Visitors.Interfaces;

namespace Example;

internal class Program
{
    public static void Main(string[] _)
    {
        Connection connection = new();

        Console.WriteLine($"{nameof(Connection)}.Connected: {connection.IsConnected()}");

        connection.BeginConnect();
        connection.ActivateUnit(456);

        connection.FinishConnect();

        Console.WriteLine($"{nameof(Connection)}.Connected: {connection.IsConnected()}");
    }
}

public sealed class Connection
{
    private interface IStateDependentComputation<T> : IVisitor<Uninitialized, Connecting, Connected, Disconnected, Error, T> { }
    private interface IStateTransition : IStateDependentComputation<IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error>> { }

    private static readonly IVisitableFactory<UnitActivateRequest, UnitDeactivateRequest> OutgoingMessage = new VisitableFactory<UnitActivateRequest, UnitDeactivateRequest>();
    private static readonly IVisitableFactory<Uninitialized, Connecting, Connected, Disconnected, Error> ConnectionState = new VisitableFactory<Uninitialized, Connecting, Connected, Disconnected, Error>();

    private IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> state;

    public Connection()
    {
        state = ConnectionState.Create(new Uninitialized());
    }

    public void BeginConnect() => state = state.Accept(BeginConnectFunction.Instance);
    public void FinishConnect() => state = state.Accept(FinishConnectFunction.Instance);
    public bool IsConnected() => state.Accept(IsConnectedFunction.Instance);
    public void ActivateUnit(int unitId) => state.Accept(ProcessOutgoingMessage.Instance, OutgoingMessage.Create(new UnitActivateRequest(unitId)));
    public void DectivateUnit(int unitId) => state.Accept(ProcessOutgoingMessage.Instance, OutgoingMessage.Create(new UnitDeactivateRequest(unitId)));

    private sealed class Uninitialized
    {
        public readonly Queue<IVisitable<UnitActivateRequest, UnitDeactivateRequest>> MessageQueue = new();
    }

    private sealed class Connecting(params IVisitable<UnitActivateRequest, UnitDeactivateRequest>[] requests)
    {
        public readonly Queue<IVisitable<UnitActivateRequest, UnitDeactivateRequest>> MessageQueue = new(requests);
    }

    private sealed class Connected
    {

    }

    private sealed class Disconnected
    {

    }

    private sealed class Error
    {

    }

    private record UnitActivateRequest(int UnitId);
    private record UnitActivateConfirm(int UnitId);
    private record UnitActivateReject(int UnitId, string Reason);

    private record UnitDeactivateRequest(int UnitId);
    private record UnitDeactivateConfirm(int UnitId);
    private record UnitDeactivateReject(int UnitId, string Reason);

    private sealed class BeginConnectFunction : IStateTransition
    {
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Uninitialized instance)
        {
            Console.WriteLine($"{nameof(BeginConnect)}() Transitioning from {nameof(Uninitialized)} -> {nameof(Connecting)}");
            return ConnectionState.Create(new Connecting([.. instance.MessageQueue]));
        }

        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connecting instance)
        {
            Console.WriteLine($"{nameof(BeginConnect)}() Already {nameof(Connecting)}. Doing nothing.");
            return ConnectionState.Create(instance);
        }

        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connected instance)
        {
            Console.WriteLine($"{nameof(BeginConnect)}() Already {nameof(Connected)}. Doing nothing.");
            return ConnectionState.Create(instance);
        }

        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Disconnected instance)
        {
            Console.WriteLine($"{nameof(BeginConnect)}() Transitioning from {nameof(Disconnected)} -> {nameof(Connecting)}");
            return ConnectionState.Create(new Connecting());
        }

        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Error instance)
        {
            Console.WriteLine($"{nameof(BeginConnect)}() Transitioning from {nameof(Error)} -> {nameof(Connecting)}");
            return ConnectionState.Create(new Connecting());
        }

        public static readonly BeginConnectFunction Instance = new();
    }

    private sealed class FinishConnectFunction : IStateTransition
    {
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Uninitialized instance)
            => throw new InvalidOperationException($"Cannot complete connection from {nameof(Uninitialized)} state!");
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connecting instance)
        {
            Console.WriteLine($"{nameof(FinishConnect)}() Transitioning from {nameof(Connecting)} -> {nameof(Connected)}");

            var state = ConnectionState.Create(new Connected());

            Console.WriteLine($"{nameof(FinishConnect)}() Processing {instance.MessageQueue.Count} enqueued messages");

            while (0 < instance.MessageQueue.Count)
            {
                state.Accept(ProcessOutgoingMessage.Instance, instance.MessageQueue.Dequeue());
            }

            return ConnectionState.Create(new Connected());
        }

        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connected instance) => ConnectionState.Create(instance);
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Disconnected instance)
            => throw new InvalidOperationException($"Cannot complete connection from {nameof(Disconnected)} state!");
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Error instance)
            => throw new InvalidOperationException($"Cannot complete connection from {nameof(Error)} state!");
        public static readonly FinishConnectFunction Instance = new();
    }

    private sealed class IsConnectedFunction : IStateDependentComputation<bool>
    {
        public bool Visit(Uninitialized _) => false;
        public bool Visit(Connecting _) => false;
        public bool Visit(Connected _) => true;
        public bool Visit(Disconnected instance) => false;
        public bool Visit(Error _) => false;
        public static readonly IsConnectedFunction Instance = new();
    }

    private sealed class ProcessOutgoingMessage : I5x2Visitor<Uninitialized, Connecting, Connected, Disconnected, Error, UnitActivateRequest, UnitDeactivateRequest, Nothing>
    {
        public Nothing Visit(Uninitialized uninitialized, UnitActivateRequest request)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Connection is currently {nameof(Uninitialized)}. Enqueuing {nameof(UnitActivateRequest)}");
            uninitialized.MessageQueue.Enqueue(OutgoingMessage.Create(request));
            return Nothing.Instance;
        }
        public Nothing Visit(Uninitialized uninitialized, UnitDeactivateRequest request)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Connection is currently {nameof(Uninitialized)}. Enqueuing {nameof(UnitDeactivateRequest)}");
            uninitialized.MessageQueue.Enqueue(OutgoingMessage.Create(request));
            return Nothing.Instance;
        }
        public Nothing Visit(Connecting connecting, UnitActivateRequest request)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Connection is currently {nameof(Connecting)}. Enqueuing {nameof(UnitActivateRequest)}");
            connecting.MessageQueue.Enqueue(OutgoingMessage.Create(request));
            return Nothing.Instance;
        }
        public Nothing Visit(Connecting connecting, UnitDeactivateRequest request)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Connection is currently {nameof(Connecting)}. Enqueuing {nameof(UnitDeactivateRequest)}");
            connecting.MessageQueue.Enqueue(OutgoingMessage.Create(request));
            return Nothing.Instance;
        }
        public Nothing Visit(Connected left, UnitActivateRequest right)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Unit {right.UnitId} activated!");
            return Nothing.Instance;
        }
        public Nothing Visit(Connected left, UnitDeactivateRequest right)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Unit {right.UnitId} deactivated!");
            return Nothing.Instance;
        }
        public Nothing Visit(Disconnected left, UnitActivateRequest right)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Cannot process {nameof(UnitActivateRequest)} while connection state is {nameof(Disconnected)}");
            return Nothing.Instance;
        }

        public Nothing Visit(Disconnected left, UnitDeactivateRequest right)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Cannot process {nameof(UnitDeactivateRequest)} while connection state is {nameof(Disconnected)}");
            return Nothing.Instance;
        }

        public Nothing Visit(Error left, UnitActivateRequest right)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Cannot process {nameof(UnitActivateRequest)} while connection state is {nameof(Error)}");
            return Nothing.Instance;
        }

        public Nothing Visit(Error left, UnitDeactivateRequest right)
        {
            Console.WriteLine($"{nameof(ProcessOutgoingMessage)}() Cannot process {nameof(UnitDeactivateRequest)} while connection state is {nameof(Error)}");
            return Nothing.Instance;
        }

        public static readonly ProcessOutgoingMessage Instance = new();
    }
}