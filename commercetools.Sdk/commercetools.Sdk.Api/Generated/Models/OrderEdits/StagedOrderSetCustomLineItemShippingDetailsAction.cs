using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomLineItemShippingDetailsAction : IStagedOrderSetCustomLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public StagedOrderSetCustomLineItemShippingDetailsAction()
        {
            this.Action = "setCustomLineItemShippingDetails";
        }
    }
}
