using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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

        IList<IItemState> State { get; set; }
        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        ITaxRate TaxRate { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IInventoryMode InventoryMode { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
