using System.ServiceModel;

namespace FizzBuzzWithWcf.Host
{
    public class CheckFizzBuzzClient : ClientBase<IFizzBuzzCounter>, IFizzBuzzCounter
    {
        public void DecrementCounter()
        {
            Channel.DecrementCounter();
        }

        public string GetFizzBuzzLabel()
        {
            return Channel.GetFizzBuzzLabel();
        }

        public void IncrementCounter()
        {
            Channel.IncrementCounter();
        }
    }
}
