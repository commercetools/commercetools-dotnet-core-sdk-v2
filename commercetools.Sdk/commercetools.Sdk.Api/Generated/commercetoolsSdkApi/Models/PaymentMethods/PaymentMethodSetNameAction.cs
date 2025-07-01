using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetNameAction : IPaymentMethodSetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public PaymentMethodSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
