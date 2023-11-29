using Abstractions.Functional;
using Abstractions.SumTypes.Variants;
using Abstractions.Visitors.Extensions;
using Abstractions.Visitors.Interfaces;

namespace Example
{
    internal class Program
    {
        public static void Main(string[] _)
        {
            Connection connection = new();

            Console.WriteLine($"{nameof(Connection)} {(connection.IsConnected() ? "is" : "is not")} connected.");

            connection.BeginConnect();
            connection.ActivateUnit(456);

            Console.WriteLine($"{nameof(Connection)} {(connection.IsConnected() ? "is" : "is not")} connected.");
        }

        private sealed class Test : IVisitor<string, int, string>
        {
            public string Visit(string instance) => "Contains a string.";

            public string Visit(int instance) => "Contains an int.";
        }
    }

    public sealed class Connection
    {
        private interface IStateDependentComputation<T> : IVisitor<Uninitialized, Connecting, Connected, Disconnected, Error, T> { }
        private interface IStateTransition : IStateDependentComputation<Variant<Uninitialized, Connecting, Connected, Disconnected, Error>> { }

        private Variant<Uninitialized, Connecting, Connected, Disconnected, Error> state = new Uninitialized();

        public bool IsConnected() => state.Accept(new GetIsConnected());
        public void ActivateUnit(int unitId) => state.Accept(new ProcessOutgoingMessage(), new Variant<UnitActivateRequest, UnitDeactivateRequest>(new UnitActivateRequest(unitId)));
        public void DectivateUnit(int unitId) => state.Accept(new ProcessOutgoingMessage(), new Variant<UnitActivateRequest, UnitDeactivateRequest>(new UnitDeactivateRequest(unitId)));
        public void BeginConnect() => state = new Connecting();

        private sealed class DoBeginConnect : IStateTransition
        {
            public Variant<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Uninitialized instance) => new Connecting();
            public Variant<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connecting instance) => throw new NotImplementedException();
            public Variant<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Connected instance) => throw new NotImplementedException();
            public Variant<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Disconnected instance) => throw new NotImplementedException();
            public Variant<Uninitialized, Connecting, Connected, Disconnected, Error> Visit(Error instance) => throw new NotImplementedException();
        }

        private sealed class GetIsConnected : IStateDependentComputation<bool>
        {
            public bool Visit(Uninitialized _) => false;
            public bool Visit(Connecting _) => false;
            public bool Visit(Connected _) => true;
            public bool Visit(Disconnected instance) => false;
            public bool Visit(Error _) => false;
        }

        private sealed class ProcessOutgoingMessage : I5x2Visitor<Uninitialized, Connecting, Connected, Disconnected, Error, UnitActivateRequest, UnitDeactivateRequest, Nothing>
        {
            public Nothing Visit(Uninitialized uninitialized, UnitActivateRequest request) { uninitialized.MessageQueue.Enqueue(request);  return Nothing.Instance; }
            public Nothing Visit(Uninitialized uninitialized, UnitDeactivateRequest request) { uninitialized.MessageQueue.Enqueue(request); return Nothing.Instance; }
            public Nothing Visit(Connecting connecting, UnitActivateRequest request) { connecting.MessageQueue.Enqueue(request);  return Nothing.Instance; }
            public Nothing Visit(Connecting connecting, UnitDeactivateRequest request) { connecting.MessageQueue.Enqueue(request); return Nothing.Instance; }
            public Nothing Visit(Connected left, UnitActivateRequest right) => throw new NotImplementedException();
            public Nothing Visit(Connected left, UnitDeactivateRequest right) => throw new NotImplementedException();
            public Nothing Visit(Disconnected left, UnitActivateRequest right) => Nothing.Instance;
            public Nothing Visit(Disconnected left, UnitDeactivateRequest right) => Nothing.Instance;
            public Nothing Visit(Error left, UnitActivateRequest right) => Nothing.Instance;
            public Nothing Visit(Error left, UnitDeactivateRequest right) => Nothing.Instance;
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

        private sealed class UnitActivateRequest
        {
            public UnitActivateRequest(int unitId) => UnitId = unitId;
            public readonly int UnitId;
        }

        private sealed class UnitActivateConfirm
        {
            public UnitActivateConfirm(int unitId) => UnitId = unitId;
            public readonly int UnitId;
        }

        private sealed class UnitActivateReject
        {
            public UnitActivateReject(int unitId, string reason)
            {
                UnitId = unitId;
                Reason = reason;
            }

            public readonly int UnitId;
            public readonly string Reason;
        }

        private sealed class UnitDeactivateRequest
        {
            public UnitDeactivateRequest(int unitId) => UnitId = unitId;
            public readonly int UnitId;
        }
    }
}