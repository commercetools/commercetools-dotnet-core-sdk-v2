using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetDiscountedPriceAction : IProductSetDiscountedPriceAction
    {
        public string Action { get; set; }

        public string PriceId { get; set; }

        public bool? Staged { get; set; }

        public IDiscountedPriceDraft Discounted { get; set; }
        public ProductSetDiscountedPriceAction()
        {
            this.Action = "setDiscountedPrice";
        }
    }
}
