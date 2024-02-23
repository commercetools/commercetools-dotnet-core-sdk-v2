using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeLineItemQuantityAction : ICartChangeLineItemQuantityAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public long Quantity { get; set; }

        public IMoney ExternalPrice { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }
        public CartChangeLineItemQuantityAction()
        {
            this.Action = "changeLineItemQuantity";
        }
    }
}
