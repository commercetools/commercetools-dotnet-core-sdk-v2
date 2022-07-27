using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.LineItemImportDraft))]
    public partial interface ILineItemImportDraft
    {
        string ProductId { get; set; }

        ILocalizedString Name { get; set; }

        IProductVariantImportDraft Variant { get; set; }

        IPriceDraft Price { get; set; }

        long Quantity { get; set; }

        List<IItemState> State { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        ITaxRate TaxRate { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IInventoryMode InventoryMode { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
