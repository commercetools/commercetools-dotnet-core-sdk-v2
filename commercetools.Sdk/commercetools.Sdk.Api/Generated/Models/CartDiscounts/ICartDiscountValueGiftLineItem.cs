using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem))]
    public partial interface ICartDiscountValueGiftLineItem : ICartDiscountValue
    {
        IProductReference Product { get; set; }

        long VariantId { get; set; }

        IChannelReference SupplyChannel { get; set; }

        IChannelReference DistributionChannel { get; set; }

    }
}
