using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceDraft : IStandalonePriceDraft
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public IMoney Value { get; set; }

        public string Country { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public IList<IPriceTierDraft> Tiers { get; set; }
        public IEnumerable<IPriceTierDraft> TiersEnumerable { set => Tiers = value.ToList(); }


        public IDiscountedPriceDraft Discounted { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public bool? Active { get; set; }
    }
}
