namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ItemShippingTarget : IItemShippingTarget
    {
        public string AddressKey { get; set; }

        public long Quantity { get; set; }

        public string ShippingMethodKey { get; set; }
    }
}
