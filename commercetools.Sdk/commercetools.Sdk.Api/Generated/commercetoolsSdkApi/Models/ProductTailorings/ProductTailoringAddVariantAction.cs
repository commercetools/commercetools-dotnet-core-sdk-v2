using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringAddVariantAction : IProductTailoringAddVariantAction
    {
        public string Action { get; set; }

        public long? Id { get; set; }

        public string Sku { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IAssetDraft> Assets { get; set; }

        public IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }

        public bool? Staged { get; set; }
        public ProductTailoringAddVariantAction()
        {
            this.Action = "addVariant";
        }
    }
}
