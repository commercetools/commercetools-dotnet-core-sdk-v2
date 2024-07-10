using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductTailoringDescriptionSetMessage : IProductTailoringDescriptionSetMessage
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

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString OldDescription { get; set; }
        public ProductTailoringDescriptionSetMessage()
        {
            this.Type = "ProductTailoringDescriptionSet";
        }
    }
}
