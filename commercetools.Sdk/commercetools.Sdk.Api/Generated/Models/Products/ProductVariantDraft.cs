using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductVariantDraft : IProductVariantDraft
    {
        public string Sku { get; set; }

        public string Key { get; set; }

        public IList<IPriceDraft> Prices { get; set; }
        public IEnumerable<IPriceDraft> PricesEnumerable { set => Prices = value.ToList(); }


        public IList<IAttribute> Attributes { get; set; }
        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        public IList<IImage> Images { get; set; }
        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        public IList<IAssetDraft> Assets { get; set; }
        public IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }

    }
}
