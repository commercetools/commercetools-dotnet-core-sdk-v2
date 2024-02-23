using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderRemovePaymentAction : IStagedOrderRemovePaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public StagedOrderRemovePaymentAction()
        {
            this.Action = "removePayment";
        }
    }
}
