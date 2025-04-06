using Abstractions.Functional;
using Abstractions.SumTypes.Variants;
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

    private readonly IVisitableFactory<UnitActivateRequest, UnitDeactivateRequest> outgoingMessage;
    private readonly IVisitableFactory<Uninitialized, Connecting, Connected, Disconnected, Error> connectionState;

    private IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> state;

    public Connection()
    {
        outgoingMessage = new VisitableFactory<UnitActivateRequest, UnitDeactivateRequest>();
        connectionState = new VisitableFactory<Uninitialized, Connecting, Connected, Disconnected, Error>();
        state = connectionState.Create(new Uninitialized());
    }

    public bool IsConnected() => state.Accept(IsConnectedFunction.Instance);
    public void ActivateUnit(int unitId) => state.Accept(ProcessOutgoingMessage.Instance, outgoingMessage.Create(new UnitActivateRequest(unitId)));
    public void DectivateUnit(int unitId) => state.Accept(ProcessOutgoingMessage.Instance, outgoingMessage.Create(new UnitDeactivateRequest(unitId)));
    public void BeginConnect() => state = state.Accept(BeginConnectFunction.Instance);

    private sealed class BeginConnectFunction : IStateTransition
    {
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Uninitialized instance) => connectionState.Create(new Connecting());
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connecting instance) => instance;
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connected instance) => instance;
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Disconnected instance) => new Connecting();
        public IVisitable<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Error instance) => new Connecting();
        public static readonly BeginConnectFunction Instance = new();
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
        public Nothing Visit(Uninitialized uninitialized, UnitActivateRequest request) { uninitialized.MessageQueue.Enqueue(request); return Nothing.Instance; }
        public Nothing Visit(Uninitialized uninitialized, UnitDeactivateRequest request) { uninitialized.MessageQueue.Enqueue(request); return Nothing.Instance; }
        public Nothing Visit(Connecting connecting, UnitActivateRequest request) { connecting.MessageQueue.Enqueue(request); return Nothing.Instance; }
        public Nothing Visit(Connecting connecting, UnitDeactivateRequest request) { connecting.MessageQueue.Enqueue(request); return Nothing.Instance; }
        public Nothing Visit(Connected left, UnitActivateRequest right) { Console.WriteLine($"Unit {right.UnitId} activated!"); return Nothing.Instance; }
        public Nothing Visit(Connected left, UnitDeactivateRequest right) { Console.WriteLine($"Unit {right.UnitId} deactivated!"); return Nothing.Instance; }
        public Nothing Visit(Disconnected left, UnitActivateRequest right) => Nothing.Instance;
        public Nothing Visit(Disconnected left, UnitDeactivateRequest right) => Nothing.Instance;
        public Nothing Visit(Error left, UnitActivateRequest right) => Nothing.Instance;
        public Nothing Visit(Error left, UnitDeactivateRequest right) => Nothing.Instance;
        public static readonly ProcessOutgoingMessage Instance = new();
    }

    private sealed class Uninitialized
    {
        public readonly Queue<Variant<UnitActivateRequest, UnitDeactivateRequest>> MessageQueue = new();
    }

    private sealed class Connecting
    {
        public readonly Queue<Variant<UnitActivateRequest, UnitDeactivateRequest>> MessageQueue = new();
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
}