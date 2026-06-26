using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetImagesAction : IVariantSetImagesAction
    {
        public string Action { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public bool? Staged { get; set; }
        public VariantSetImagesAction()
        {
            this.Action = "setImages";
        }
    }
}
