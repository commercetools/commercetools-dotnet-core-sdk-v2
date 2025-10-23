using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductVariant : IProductVariant
    {
        public long Id { get; set; }

        public string Sku { get; set; }

        public string Key { get; set; }

        public IList<IPrice> Prices { get; set; }

        public IEnumerable<IPrice> PricesEnumerable { set => Prices = value.ToList(); }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public IPrice Price { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IAsset> Assets { get; set; }

        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        public IProductVariantAvailability Availability { get; set; }

        public bool? IsMatchingVariant { get; set; }

        public IScopedPrice ScopedPrice { get; set; }

        public bool? ScopedPriceDiscounted { get; set; }

        public IList<IPrice> RecurrencePrices { get; set; }

        public IEnumerable<IPrice> RecurrencePricesEnumerable { set => RecurrencePrices = value.ToList(); }
    }
}
