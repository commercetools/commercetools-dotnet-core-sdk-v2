using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Variants
{

    public partial class VariantImport : IVariantImport
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public IProductKeyReference Product { get; set; }

        public bool? Publish { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public IList<IAsset> Assets { get; set; }

        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }
    }
}
