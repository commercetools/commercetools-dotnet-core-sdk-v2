using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetDiscountedPriceAction))]
    public partial interface IProductSetDiscountedPriceAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        bool? Staged { get; set; }

        IDiscountedPriceDraft Discounted { get; set; }

    }
}
