using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueGiftLineItem : ICartDiscountValueGiftLineItem
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public IChannelReference SupplyChannel { get; set; }

        public IChannelReference DistributionChannel { get; set; }
        public CartDiscountValueGiftLineItem()
        {
            this.Type = "giftLineItem";
        }
    }
}
