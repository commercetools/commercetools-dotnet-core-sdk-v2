namespace commercetools.Api.Models.Carts
{
    public partial class CartRemoveCustomLineItemAction : ICartRemoveCustomLineItemAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }
        public CartRemoveCustomLineItemAction()
        {
            this.Action = "removeCustomLineItem";
        }
    }
}
