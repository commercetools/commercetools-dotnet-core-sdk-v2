using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantDraft : IVariantDraft
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public bool? Publish { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public IList<IAssetDraft> Assets { get; set; }

        public IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }
    }
}
