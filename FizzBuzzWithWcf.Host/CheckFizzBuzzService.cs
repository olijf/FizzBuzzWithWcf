using System.ServiceModel;

namespace FizzBuzzWithWcf.Host
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                ConcurrencyMode = ConcurrencyMode.Single)]
    public class CheckFizzBuzzService : IFizzBuzzCounter
    {
        //private int Counter = 1;

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void DecrementCounter()
        {
            var Counter = 0;
            var file = System.IO.File.ReadAllText("counter.txt");
            int.TryParse(file, out Counter);
            if (Counter >= 2)
            {
                Counter--;
            }
            System.IO.File.WriteAllText("counter.txt", string.Format("{0}", Counter));
        }


        public string GetFizzBuzzLabel()
        {
            var Counter = 0;
            var file = System.IO.File.ReadAllText("counter.txt");
            int.TryParse(file, out Counter);
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

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void IncrementCounter()
        {
            var Counter = 0;
            var file = System.IO.File.ReadAllText("counter.txt");
            int.TryParse(file, out Counter);
            Counter++;
            try
            {

                System.IO.File.WriteAllText("counter.txt", string.Format("{0}", Counter));
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}
