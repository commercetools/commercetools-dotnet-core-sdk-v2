using commercetools.Sdk.Api.Models.ShippingMethods;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class CartValueType : ICartValueType
    {
        public IShippingRateTierType Type { get; set; }
        public CartValueType()
        {
            this.Type = IShippingRateTierType.FindEnum("CartValue");
        }
    }
}
