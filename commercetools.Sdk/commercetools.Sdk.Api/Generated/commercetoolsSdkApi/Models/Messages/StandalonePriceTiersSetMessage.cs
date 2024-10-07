using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceTiersSetMessage : IStandalonePriceTiersSetMessage
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

        public IList<IPriceTier> Tiers { get; set; }

        public IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }

        public IList<IPriceTier> PreviousTiers { get; set; }

        public IEnumerable<IPriceTier> PreviousTiersEnumerable { set => PreviousTiers = value.ToList(); }
        public StandalonePriceTiersSetMessage()
        {
            this.Type = "StandalonePriceTiersSet";
        }
    }
}
