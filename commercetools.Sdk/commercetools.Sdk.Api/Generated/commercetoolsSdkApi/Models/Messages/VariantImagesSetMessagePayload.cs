using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantImagesSetMessagePayload : IVariantImagesSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IImage> OldImages { get; set; }

        public IEnumerable<IImage> OldImagesEnumerable { set => OldImages = value.ToList(); }

        public bool Staged { get; set; }
        public VariantImagesSetMessagePayload()
        {
            this.Type = "VariantImagesSet";
        }
    }
}
