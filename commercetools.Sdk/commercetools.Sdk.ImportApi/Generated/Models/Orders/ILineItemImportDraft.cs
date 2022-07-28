using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.LineItemImportDraft))]
    public partial interface ILineItemImportDraft
    {
        IProductKeyReference Product { get; set; }

        ILocalizedString Name { get; set; }

        ILineItemProductVariantImportDraft Variant { get; set; }

        ILineItemPrice Price { get; set; }

        decimal Quantity { get; set; }

        List<IItemState> State { get; set; }

        IChannelKeyReference SupplyChannel { get; set; }

        IChannelKeyReference DistributionChannel { get; set; }

        ITaxRate TaxRate { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
