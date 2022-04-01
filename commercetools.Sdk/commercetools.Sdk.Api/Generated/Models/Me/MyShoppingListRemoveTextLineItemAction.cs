namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyShoppingListRemoveTextLineItemAction : IMyShoppingListRemoveTextLineItemAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public long? Quantity { get; set; }
        public MyShoppingListRemoveTextLineItemAction()
        {
            this.Action = "removeTextLineItem";
        }
    }
}
