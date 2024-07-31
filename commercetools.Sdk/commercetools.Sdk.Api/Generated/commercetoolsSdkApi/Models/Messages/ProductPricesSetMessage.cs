using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPricesSetMessage : IProductPricesSetMessage
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

        public long VariantId { get; set; }

        public IList<IPrice> Prices { get; set; }

        public IEnumerable<IPrice> PricesEnumerable { set => Prices = value.ToList(); }

        public bool Staged { get; set; }
        public ProductPricesSetMessage()
        {
            this.Type = "ProductPricesSet";
        }
    }
}
