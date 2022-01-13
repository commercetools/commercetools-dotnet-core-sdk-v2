using commercetools.Api.Models.Channels;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Common
{
    public partial class QueryPrice : IQueryPrice
    {
        public string Id { get; set; }

        public IMoney Value { get; set; }

        public string Country { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public IChannelReference Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public IDiscountedPriceDraft Discounted { get; set; }

        public ICustomFields Custom { get; set; }

        public List<IPriceTierDraft> Tiers { get; set; }
    }
}
