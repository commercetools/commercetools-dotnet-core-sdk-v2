using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Price))]
    public partial interface IPrice
    {
        string Id { get; set; }

        string Key { get; set; }

        ITypedMoney Value { get; set; }

        string Country { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        IChannelReference Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        IDiscountedPrice Discounted { get; set; }

        IList<IPriceTier> Tiers { get; set; }
        IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


        ICustomFields Custom { get; set; }

    }
}
