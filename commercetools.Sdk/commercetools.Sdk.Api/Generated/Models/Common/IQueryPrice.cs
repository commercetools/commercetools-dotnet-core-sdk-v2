using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.QueryPrice))]
    public partial interface IQueryPrice
    {
        string Id { get; set; }

        IMoney Value { get; set; }

        string Country { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        IChannelReference Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        IDiscountedPriceDraft Discounted { get; set; }

        ICustomFields Custom { get; set; }

        IList<IPriceTierDraft> Tiers { get; set; }
        IEnumerable<IPriceTierDraft> TiersEnumerable { set => Tiers = value.ToList(); }


    }
}
