using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductVariant))]
    public partial interface IProductVariant
    {
        long Id { get; set; }

        string Sku { get; set; }

        string Key { get; set; }

        List<IPrice> Prices { get; set; }

        List<IAttribute> Attributes { get; set; }

        IPrice Price { get; set; }

        List<IImage> Images { get; set; }

        List<IAsset> Assets { get; set; }

        IProductVariantAvailability Availability { get; set; }

        bool? IsMatchingVariant { get; set; }

        IScopedPrice ScopedPrice { get; set; }

        bool? ScopedPriceDiscounted { get; set; }
    }
}
