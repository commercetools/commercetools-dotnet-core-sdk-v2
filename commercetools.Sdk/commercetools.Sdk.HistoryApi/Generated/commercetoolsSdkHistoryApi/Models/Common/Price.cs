using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Price : IPrice
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public ITypedMoney Value { get; set; }

        public string Country { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public IChannelReference Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public IDiscountedPrice Discounted { get; set; }

        public IList<IPriceTier> Tiers { get; set; }

        public IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }

        public ICustomFields Custom { get; set; }

        public IRecurrencePolicyReference RecurrencePolicy { get; set; }
    }
}
