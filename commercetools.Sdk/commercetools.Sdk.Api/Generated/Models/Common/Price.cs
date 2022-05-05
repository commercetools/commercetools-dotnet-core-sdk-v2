using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Common
{
    public partial class Price : IPrice
    {
        public string Id { get; set; }

        public ITypedMoney Value { get; set; }

        public string Country { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public IChannelReference Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public IDiscountedPrice Discounted { get; set; }

        public List<IPriceTier> Tiers { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
