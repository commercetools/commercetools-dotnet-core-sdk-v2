using commercetools.Api.Models.ShippingMethods;


namespace commercetools.Api.Models.Projects
{
    public partial class ShippingRateInputType : IShippingRateInputType
    {
        public IShippingRateTierType Type { get; set;}
    }
}
