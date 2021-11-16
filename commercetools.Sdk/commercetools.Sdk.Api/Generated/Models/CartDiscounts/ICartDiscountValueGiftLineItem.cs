using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem))]
    public partial interface ICartDiscountValueGiftLineItem : ICartDiscountValue
    {
        IProductReference Product { get; set;}
        
        long VariantId { get; set;}
        
        IChannelReference SupplyChannel { get; set;}
        
        IChannelReference DistributionChannel { get; set;}
    }
}
