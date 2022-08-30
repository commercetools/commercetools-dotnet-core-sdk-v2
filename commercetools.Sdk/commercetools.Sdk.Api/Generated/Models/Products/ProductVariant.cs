using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductVariant : IProductVariant
    {
        public long Id { get; set; }

        public string Sku { get; set; }

        public string Key { get; set; }

        public List<IPrice> Prices { get; set; }

        public List<IAttribute> Attributes { get; set; }

        public IPrice Price { get; set; }

        public List<IImage> Images { get; set; }

        public List<IAsset> Assets { get; set; }

        public IProductVariantAvailability Availability { get; set; }

        public bool? IsMatchingVariant { get; set; }

        public IScopedPrice ScopedPrice { get; set; }

        public bool? ScopedPriceDiscounted { get; set; }
    }
}
