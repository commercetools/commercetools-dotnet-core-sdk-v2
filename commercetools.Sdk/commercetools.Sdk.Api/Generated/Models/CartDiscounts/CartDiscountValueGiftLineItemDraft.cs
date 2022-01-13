using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Products;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueGiftLineItemDraft : ICartDiscountValueGiftLineItemDraft
    {
        public string Type { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public long VariantId { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public CartDiscountValueGiftLineItemDraft()
        {
            this.Type = "giftLineItem";
        }
    }
}
