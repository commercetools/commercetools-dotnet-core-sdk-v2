using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetReturnPaymentStateAction : IStagedOrderSetReturnPaymentStateAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public IReturnPaymentState PaymentState { get; set; }
        public StagedOrderSetReturnPaymentStateAction()
        {
            this.Action = "setReturnPaymentState";
        }
    }
}
