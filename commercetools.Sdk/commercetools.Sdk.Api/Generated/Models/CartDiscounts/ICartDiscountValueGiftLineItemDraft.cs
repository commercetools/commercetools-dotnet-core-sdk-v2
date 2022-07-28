using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft))]
    public partial interface ICartDiscountValueGiftLineItemDraft : ICartDiscountValueDraft
    {
        IProductResourceIdentifier Product { get; set; }

        long VariantId { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

    }
}
