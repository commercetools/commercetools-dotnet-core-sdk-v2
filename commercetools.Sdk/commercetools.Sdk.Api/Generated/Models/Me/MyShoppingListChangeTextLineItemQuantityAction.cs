namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListChangeTextLineItemQuantityAction : IMyShoppingListChangeTextLineItemQuantityAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public long Quantity { get; set; }
        public MyShoppingListChangeTextLineItemQuantityAction()
        {
            this.Action = "changeTextLineItemQuantity";
        }
    }
}
