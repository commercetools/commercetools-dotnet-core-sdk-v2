using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddLineItemAction))]
    public partial interface ICartAddLineItemAction : ICartUpdateAction
    {
        ICustomFieldsDraft Custom { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        string ProductId { get; set; }

        long? VariantId { get; set; }

        string Sku { get; set; }

        long? Quantity { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
