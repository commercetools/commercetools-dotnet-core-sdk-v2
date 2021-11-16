using commercetools.Api.Models.ShippingMethods;


namespace commercetools.Api.Models.Projects
{
    public partial class CartScoreType : ICartScoreType
    {
        public IShippingRateTierType Type { get; set;}
        public CartScoreType()
        { 
           this.Type = IShippingRateTierType.FindEnum("CartScore");
        }
    }
}
