using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class CartRemoveLineItemAction : ICartRemoveLineItemAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public long? Quantity { get; set; }

        public IMoney ExternalPrice { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        public IItemShippingDetailsDraft ShippingDetailsToRemove { get; set; }
        public CartRemoveLineItemAction()
        {
            this.Action = "removeLineItem";
        }
    }
}
