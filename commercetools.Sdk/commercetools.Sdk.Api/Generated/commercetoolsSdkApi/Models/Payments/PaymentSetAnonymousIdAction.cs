

namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetAnonymousIdAction : IPaymentSetAnonymousIdAction
    {
        public string Action { get; set; }

        public string AnonymousId { get; set; }
        public PaymentSetAnonymousIdAction()
        {
            this.Action = "setAnonymousId";
        }
    }
}
