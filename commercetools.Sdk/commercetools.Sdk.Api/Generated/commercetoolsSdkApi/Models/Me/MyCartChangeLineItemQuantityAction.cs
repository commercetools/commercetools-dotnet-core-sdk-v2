namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartChangeLineItemQuantityAction : IMyCartChangeLineItemQuantityAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public long Quantity { get; set; }
        public MyCartChangeLineItemQuantityAction()
        {
            this.Action = "changeLineItemQuantity";
        }
    }
}
