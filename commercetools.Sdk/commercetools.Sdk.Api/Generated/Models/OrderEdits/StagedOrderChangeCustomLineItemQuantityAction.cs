namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeCustomLineItemQuantityAction : IStagedOrderChangeCustomLineItemQuantityAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public double Quantity { get; set; }
        public StagedOrderChangeCustomLineItemQuantityAction()
        {
            this.Action = "changeCustomLineItemQuantity";
        }
    }
}
