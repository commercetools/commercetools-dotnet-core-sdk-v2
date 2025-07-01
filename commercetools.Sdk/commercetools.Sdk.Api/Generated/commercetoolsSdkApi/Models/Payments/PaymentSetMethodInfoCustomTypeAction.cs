using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetMethodInfoCustomTypeAction : IPaymentSetMethodInfoCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public PaymentSetMethodInfoCustomTypeAction()
        {
            this.Action = "setMethodInfoCustomType";
        }
    }
}
