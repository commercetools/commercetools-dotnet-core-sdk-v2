using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Payments
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
