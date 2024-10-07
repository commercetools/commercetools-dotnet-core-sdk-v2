using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductVariantTailoringDraft : IProductVariantTailoringDraft
    {
        public long? Id { get; set; }

        public string Sku { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IAsset> Assets { get; set; }

        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        public IList<IProductTailoringAttribute> Attributes { get; set; }

        public IEnumerable<IProductTailoringAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }
    }
}
