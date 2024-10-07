using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetExternalImagesAction : IProductTailoringSetExternalImagesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public bool? Staged { get; set; }
        public ProductTailoringSetExternalImagesAction()
        {
            this.Action = "setImages";
        }
    }
}
