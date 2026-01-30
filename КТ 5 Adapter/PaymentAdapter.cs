using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ_5_Adapter
{
    public class PaymentAdapter : IPaymentService
    {
        private readonly BankApi _bankApi;

        public PaymentAdapter(BankApi bankApi)
        {
            _bankApi = bankApi;
        }

        public void Pay(decimal amount)
        {
            // Вызов метода Adaptee для обработки платежа
            _bankApi.ProcessTransaction(amount, false);
        }

        public void Refund(decimal amount)
        {
            // Вызов метода Adaptee для обработки возврата
            _bankApi.ProcessTransaction(amount, true);
        }
    }
}
