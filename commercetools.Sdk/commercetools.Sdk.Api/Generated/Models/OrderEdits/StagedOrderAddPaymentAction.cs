using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddPaymentAction : IStagedOrderAddPaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public StagedOrderAddPaymentAction()
        {
            this.Action = "addPayment";
        }
    }
}
