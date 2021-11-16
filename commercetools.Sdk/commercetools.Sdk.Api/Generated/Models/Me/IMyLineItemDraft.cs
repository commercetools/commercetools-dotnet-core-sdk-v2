using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyLineItemDraft))]
    public partial interface IMyLineItemDraft
    {
        string ProductId { get; set; }

        long? VariantId { get; set; }

        long Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        string Sku { get; set; }
    }
}
