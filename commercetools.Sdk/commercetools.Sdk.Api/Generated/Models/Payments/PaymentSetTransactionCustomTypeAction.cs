using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetTransactionCustomTypeAction : IPaymentSetTransactionCustomTypeAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public PaymentSetTransactionCustomTypeAction()
        {
            this.Action = "setTransactionCustomType";
        }
    }
}
