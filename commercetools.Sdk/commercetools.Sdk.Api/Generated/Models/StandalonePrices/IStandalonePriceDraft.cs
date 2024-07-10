using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceDraft))]
    public partial interface IStandalonePriceDraft
    {
        string Key { get; set; }

        string Sku { get; set; }

        IMoney Value { get; set; }

        string Country { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        IList<IPriceTierDraft> Tiers { get; set; }
        IEnumerable<IPriceTierDraft> TiersEnumerable { set => Tiers = value.ToList(); }


        IDiscountedPriceDraft Discounted { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IStagedPriceDraft Staged { get; set; }

        bool? Active { get; set; }

    }
}
