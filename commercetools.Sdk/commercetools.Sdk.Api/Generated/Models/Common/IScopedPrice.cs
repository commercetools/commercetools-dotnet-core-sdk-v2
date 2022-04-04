using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.ScopedPrice))]
    public partial interface IScopedPrice
    {
        string Id { get; set; }

        ITypedMoney Value { get; set; }

        ITypedMoney CurrentValue { get; set; }

        string Country { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        IChannelReference Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        IDiscountedPrice Discounted { get; set; }

        ICustomFields Custom { get; set; }
    }
}
