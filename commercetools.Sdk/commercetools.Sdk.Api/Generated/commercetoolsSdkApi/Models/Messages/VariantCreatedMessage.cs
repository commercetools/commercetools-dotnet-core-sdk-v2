using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantCreatedMessage : IVariantCreatedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

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
        public VariantCreatedMessage()
        {
            this.Type = "VariantCreated";
        }
    }
}
