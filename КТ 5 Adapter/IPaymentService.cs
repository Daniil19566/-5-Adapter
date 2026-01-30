using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ_5_Adapter
{
    internal interface IPaymentService
    {
        void Pay(decimal amount);
        void Refund(decimal amount);
    }
}
