using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetCustomTypeAction : IPaymentMethodSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public PaymentMethodSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
