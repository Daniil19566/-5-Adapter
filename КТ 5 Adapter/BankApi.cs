using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ_5_Adapter
{
   public class BankApi
    {
        public void ProcessTransaction(decimal amount, bool isRefund)
        {
            if (isRefund)
            {
                Console.WriteLine($"Refunding amount: {amount}");
            }
            else
            {
                Console.WriteLine($"Processing payment of amount: {amount}");
            }
        }
    }
}
