using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using commercetools.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.LineItemImportDraft))]
    public partial interface ILineItemImportDraft
    {
        IProductKeyReference Product { get; set; }

        ILocalizedString Name { get; set; }

        ILineItemProductVariantImportDraft Variant { get; set; }

        ILineItemPrice Price { get; set; }

        double Quantity { get; set; }

        List<IItemState> State { get; set; }

        IChannelKeyReference SupplyChannel { get; set; }

        IChannelKeyReference DistributionChannel { get; set; }

        ITaxRate TaxRate { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
