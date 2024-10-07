using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class ProductVariantImport : IProductVariantImport
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public bool IsMasterVariant { get; set; }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IAsset> Assets { get; set; }

        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        public bool? Staged { get; set; }

        public IProductKeyReference Product { get; set; }
    }
}
