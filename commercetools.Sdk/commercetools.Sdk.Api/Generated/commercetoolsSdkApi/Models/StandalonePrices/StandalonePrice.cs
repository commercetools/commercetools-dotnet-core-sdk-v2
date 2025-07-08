using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.RecurrencePolicies;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePrice : IStandalonePrice
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public string Sku { get; set; }

        public ITypedMoney Value { get; set; }

        public string Country { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public IChannelReference Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public IList<IPriceTier> Tiers { get; set; }

        public IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }

        public IDiscountedPrice Discounted { get; set; }

        public ICustomFields Custom { get; set; }

        public IStagedStandalonePrice Staged { get; set; }

        public bool Active { get; set; }

        public IRecurrencePolicyReference RecurrencePolicy { get; set; }
    }
}
