using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantCreatedMessagePayload : IVariantCreatedMessagePayload
    {
        public string Type { get; set; }

        public string Id { get; set; }

        public string ProductId { get; set; }

        public int VariantId { get; set; }

        public string Key { get; set; }

        public string Sku { get; set; }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public IList<IAsset> Assets { get; set; }

        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public bool Publish { get; set; }
        public VariantCreatedMessagePayload()
        {
            this.Type = "VariantCreated";
        }
    }
}
