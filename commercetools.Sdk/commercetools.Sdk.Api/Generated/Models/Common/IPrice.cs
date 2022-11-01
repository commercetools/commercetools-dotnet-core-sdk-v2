using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        List<IPriceTier> Tiers { get; set; }

        ICustomFields Custom { get; set; }

    }
}
