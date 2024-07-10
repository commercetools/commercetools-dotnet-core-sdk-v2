using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetCustomTypeAction : IPaymentSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public PaymentSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
