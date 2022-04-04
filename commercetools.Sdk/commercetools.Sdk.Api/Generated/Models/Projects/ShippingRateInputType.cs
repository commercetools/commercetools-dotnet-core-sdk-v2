using commercetools.Sdk.Api.Models.ShippingMethods;


namespace commercetools.Sdk.Api.Models.Projects
{
    public partial class ShippingRateInputType : IShippingRateInputType
    {
        public IShippingRateTierType Type { get; set; }
    }
}
