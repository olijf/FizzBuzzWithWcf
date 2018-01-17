using System.ServiceModel;

namespace FizzBuzzWithWcf.Host
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CheckFizzBuzzService : IFizzBuzzCounter
    {
        private int Counter = 1;

        public void DecrementCounter()
        {
            if (Counter >= 2)
            {
                Counter--;
            }
        }

        public string GetFizzBuzzLabel()
        {
            var result = string.Empty;
            if (Counter % 15 == 0)
            {
                result += "Guus Geluk";
            }
            else if (Counter % 3 == 0)
            {
                result += "Guus";
            }
            else if (Counter % 5 == 0)
            {
                result += "Geluk";
            }
            else
            {
                result += Counter;
            }

            return result;
        }

        public void IncrementCounter()
        {
            Counter++;
        }
    }
}
