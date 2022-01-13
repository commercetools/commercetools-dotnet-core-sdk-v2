using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductPriceDiscountsSetUpdatedPrice : IProductPriceDiscountsSetUpdatedPrice
    {
        public int VariantId { get; set; }

        public string VariantKey { get; set; }

        public string Sku { get; set; }

        public string PriceId { get; set; }

        public IDiscountedPrice Discounted { get; set; }

        public bool Staged { get; set; }
    }
}
