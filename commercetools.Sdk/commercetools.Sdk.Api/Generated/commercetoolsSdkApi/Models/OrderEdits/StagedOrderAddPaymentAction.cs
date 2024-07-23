using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.OrderEdits
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
