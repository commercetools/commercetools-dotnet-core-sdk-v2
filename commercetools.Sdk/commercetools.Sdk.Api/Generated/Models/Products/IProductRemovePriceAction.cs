using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductRemovePriceAction))]
    public partial interface IProductRemovePriceAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        string Sku { get; set; }

        long? VariantId { get; set; }

        IPriceDraft Price { get; set; }

        bool? Staged { get; set; }

    }
}
