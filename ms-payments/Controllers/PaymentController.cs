using Microsoft.AspNetCore.Mvc;
using ms_payments.Services;

namespace ms_payments.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public ActionResult<string> ProcessPayment([FromBody] PaymentRequest request)
        {
            var result = _paymentService.ProcessPayment(request);
            return Ok(result);
        }
    }
}
