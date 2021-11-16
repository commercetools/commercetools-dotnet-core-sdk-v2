using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetDiscountedPriceAction))]
    public partial interface IProductSetDiscountedPriceAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        bool? Staged { get; set; }

        IDiscountedPriceDraft Discounted { get; set; }
    }
}
