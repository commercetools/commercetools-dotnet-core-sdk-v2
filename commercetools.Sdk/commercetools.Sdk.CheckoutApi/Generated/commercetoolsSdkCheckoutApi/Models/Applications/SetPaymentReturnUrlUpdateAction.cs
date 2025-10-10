

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetPaymentReturnUrlUpdateAction : ISetPaymentReturnUrlUpdateAction
    {
        public string Action { get; set; }

        public string PaymentReturnUrl { get; set; }
        public SetPaymentReturnUrlUpdateAction()
        {
            this.Action = "setPaymentReturnUrl";
        }
    }
}
