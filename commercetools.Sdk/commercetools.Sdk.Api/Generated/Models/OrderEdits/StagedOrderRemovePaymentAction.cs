using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.OrderEdits
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
