using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using commercetools.Sdk.ImportApi.Models.Orders;
using commercetools.Sdk.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.LineItemImportDraft))]
    public partial interface ILineItemImportDraft
    {
        IProductKeyReference Product { get; set; }

        ILocalizedString Name { get; set; }

        ILineItemProductVariantImportDraft Variant { get; set; }

        ILineItemPrice Price { get; set; }

        long Quantity { get; set; }

        IList<IItemState> State { get; set; }
        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        IChannelKeyReference SupplyChannel { get; set; }

        IChannelKeyReference DistributionChannel { get; set; }

        ITaxRate TaxRate { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ICustom Custom { get; set; }

    }
}
