using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartRemoveLineItemAction : IMyCartRemoveLineItemAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public long? Quantity { get; set; }

        public IMoney ExternalPrice { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        public IItemShippingDetailsDraft ShippingDetailsToRemove { get; set; }
        public MyCartRemoveLineItemAction()
        {
            this.Action = "removeLineItem";
        }
    }
}
