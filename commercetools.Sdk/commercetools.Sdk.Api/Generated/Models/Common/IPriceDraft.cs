using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.PriceDraft))]
    public partial interface IPriceDraft
    {
        string Key { get; set; }

        IMoney Value { get; set; }

        string Country { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        IDiscountedPriceDraft Discounted { get; set; }

        IList<IPriceTierDraft> Tiers { get; set; }
        IEnumerable<IPriceTierDraft> TiersEnumerable { set => Tiers = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
