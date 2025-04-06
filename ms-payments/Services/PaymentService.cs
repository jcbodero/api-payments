namespace ms_payments.Services
{
    public interface IPaymentService
    {
        string ProcessPayment(PaymentRequest request);
    }

    public class PaymentService : IPaymentService
    {
        public string ProcessPayment(PaymentRequest request)
        {
            // Aquí iría la lógica para procesar el pago
            return $"Pago de {request.Amount} procesado exitosamente";
        }
    }

    public class PaymentRequest
    {
        public double Amount { get; set; }
        public string Method { get; set; }
    }
}
