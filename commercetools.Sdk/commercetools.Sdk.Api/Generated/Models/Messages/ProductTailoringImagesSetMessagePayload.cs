using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductTailoringImagesSetMessagePayload : IProductTailoringImagesSetMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public IList<IImage> OldImages { get; set; }
        public IEnumerable<IImage> OldImagesEnumerable { set => OldImages = value.ToList(); }


        public IList<IImage> Images { get; set; }
        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public ProductTailoringImagesSetMessagePayload()
        {
            this.Type = "ProductTailoringImagesSet";
        }
    }
}
