using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductVariant))]
    public partial interface IProductVariant
    {
        long Id { get; set; }

        string Sku { get; set; }

        string Key { get; set; }

        IList<IPrice> Prices { get; set; }

        IEnumerable<IPrice> PricesEnumerable { set => Prices = value.ToList(); }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        IPrice Price { get; set; }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IAsset> Assets { get; set; }

        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        IProductVariantAvailability Availability { get; set; }

        bool? IsMatchingVariant { get; set; }

        IScopedPrice ScopedPrice { get; set; }

        bool? ScopedPriceDiscounted { get; set; }

    }
}
