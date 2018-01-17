using System.ServiceModel;

namespace FizzBuzzWithWcf.Host
{
    [ServiceContract]
    public interface IFizzBuzzCounter
    {
        [OperationContract]
        void IncrementCounter();

        [OperationContract]
        void DecrementCounter();

        [OperationContract]
        string GetFizzBuzzLabel();
    }
}
