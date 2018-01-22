using System.ServiceModel;

namespace FizzBuzzWithWcf.Host
{
    [ServiceContract]
    public interface IFizzBuzzCounter
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void IncrementCounter();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void DecrementCounter();

        [OperationContract]
        string GetFizzBuzzLabel();
    }
}
