using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyLineItemDraft))]
    public partial interface IMyLineItemDraft
    {
        string ProductId { get; set; }

        long? VariantId { get; set; }

        string Sku { get; set; }

        long? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
