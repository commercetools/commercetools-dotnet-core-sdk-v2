namespace commercetools.Sdk.Api.Models.Payments
{
    public partial class PaymentSetExternalIdAction : IPaymentSetExternalIdAction
    {
        public string Action { get; set; }

        public string ExternalId { get; set; }
        public PaymentSetExternalIdAction()
        {
            this.Action = "setExternalId";
        }
    }
}
