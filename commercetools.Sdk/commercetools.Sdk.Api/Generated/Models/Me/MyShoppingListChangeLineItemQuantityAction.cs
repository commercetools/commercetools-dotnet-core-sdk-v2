namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListChangeLineItemQuantityAction : IMyShoppingListChangeLineItemQuantityAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public long Quantity { get; set; }
        public MyShoppingListChangeLineItemQuantityAction()
        {
            this.Action = "changeLineItemQuantity";
        }
    }
}
