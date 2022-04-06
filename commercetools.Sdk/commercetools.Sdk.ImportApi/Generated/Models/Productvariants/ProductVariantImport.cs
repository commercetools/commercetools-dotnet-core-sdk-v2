using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class ProductVariantImport : IProductVariantImport
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public bool IsMasterVariant { get; set; }

        public List<IAttribute> Attributes { get; set; }

        public List<IImage> Images { get; set; }

        public List<IAsset> Assets { get; set; }

        public bool? Publish { get; set; }

        public IProductKeyReference Product { get; set; }
    }
}
