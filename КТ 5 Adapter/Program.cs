using КТ_5_Adapter;

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра Adaptee
        BankApi bankApi = new BankApi();

        // Создание адаптера
        IPaymentService paymentService = new PaymentAdapter(bankApi);

        // Использование адаптера для выполнения платежа и возврата
        paymentService.Pay(100.00m);
        paymentService.Refund(50.00m);
    }
}

